using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Patient_handling
{
    internal class DatabaseConnection
    {

        private SqlConnection connection;
        private string connectionString;

        public DatabaseConnection()
        {

            connectionString = "Data Source=localhost;Initial Catalog=testowanie;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }


        public void LoadDataIntoDataGridView(DataGridView dataGridView, string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {tableName}"; 
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);



                    dataGridView.DataSource = dataTable; 

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas odczytu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDataInDatabase(string tableName, string[] columnNames, string[] columnValues, string condition)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"UPDATE {tableName} SET ";
                    for (int i = 0; i < columnNames.Length; i++)
                    {
                        query += $"{columnNames[i]} = '{columnValues[i]}'";
                        if (i < columnNames.Length - 1)
                        {
                            query += ", ";
                        }
                    }
                    query += $" WHERE {condition};";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dane zostały zaktualizowane.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas aktualizowania danych: " + ex.Message);
            }
        }



        public void InsertDataToDatabase(string tableName, string[] columnNames, string[] columnValues)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) " +
                                   $"VALUES ({string.Join(", ", columnValues.Select(v => $"'{v}'"))})";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Dane zostały dodane do bazy danych.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania danych do bazy danych: " + ex.Message);
            }
        }


        public (Dictionary<int, string>, Dictionary<int, string>) LoadPatientsAndDoctorsToComboBoxes(ComboBox cbPatients)
        {
            Dictionary<int, string> patientIdsAndNames = new Dictionary<int, string>();
            Dictionary<int, string> doctorIdsAndNames = new Dictionary<int, string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Pobieranie pacjentów
                    string queryPatients = "SELECT Id, FirstName, LastName FROM Patients";
                    SqlCommand commandPatients = new SqlCommand(queryPatients, connection);
                    SqlDataReader readerPatients = commandPatients.ExecuteReader();
                    if (readerPatients.HasRows)
                    {
                        while (readerPatients.Read())
                        {
                            int id = Convert.ToInt32(readerPatients["Id"]);
                            string firstName = readerPatients["FirstName"].ToString();
                            string lastName = readerPatients["LastName"].ToString();
                            cbPatients.Items.Add($"{firstName} {lastName}");
                            patientIdsAndNames.Add(id, $"{firstName} {lastName}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak danych o pacjentach w bazie danych.");
                        return (patientIdsAndNames, doctorIdsAndNames);
                    }
                    readerPatients.Close();

               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas wczytywania danych: " + ex.Message);
            }

            return (patientIdsAndNames, doctorIdsAndNames);
        }


        public DataTable FilterData(string tableName, Dictionary<string, string> filters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM {tableName}";

                if (filters.Count > 0)
                {
                    query += " WHERE ";
                    query += string.Join(" AND ", filters.Select(f => $"{f.Key} LIKE '{f.Value}'"));
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                connection.Close();

                return dataTable;
            }
        }
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        public int GetPatientId(string patientName)
        {
     
            string[] nameParts = patientName.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];


            int patientId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM Patients WHERE FirstName=@firstName AND LastName=@lastName", connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    patientId = reader.GetInt32(0);
                }

                reader.Close();

            }

            return patientId;
        }

        public int GetDoctorId(string doctorName)
        {
            // Odseparuj imię i nazwisko pacjenta
            string[] nameParts = doctorName.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];

            // Pobierz id pacjenta z bazy
            int doctorId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT ID FROM Employees WHERE FirstName=@firstName AND LastName=@lastName", connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    doctorId = reader.GetInt32(0);
                }

                reader.Close();

            }

            return doctorId;
        }
        /*
       public bool DeleteDataFromDatabase(string tableName, string condition)
       {
           bool result = false;

           // Tworzymy połączenie z bazą danych
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               try
               {
                   // Otwieramy połączenie
                   connection.Open();

                   // Tworzymy zapytanie SQL usuwające wiersze z podanej tabeli spełniające podany warunek
                   string query = $"DELETE FROM {tableName} WHERE {condition}";

                   // Tworzymy nowy obiekt SqlCommand z zapytaniem i połączeniem
                   SqlCommand command = new SqlCommand(query, connection);

                   // Wykonujemy zapytanie
                   int rowsAffected = command.ExecuteNonQuery();

                   // Sprawdzamy, czy coś zostało usunięte
                   if (rowsAffected > 0)
                   {
                       result = true;
                   }
               }
               catch (Exception ex)
               {
                   // Obsługujemy wyjątek
                   Console.WriteLine(ex.Message);
               }
           }

           return result;
       }
       */




        /* public void DisplayVisits(TextBox doctorNameTextBox, TextBox patientNameTextBox,
                   TextBox officeNumberTextBox, TextBox dateTextBox, TextBox timeTextBox, string visitId)
          {
              try
              {

                  using (SqlConnection connection = new SqlConnection(connectionString))
                  {
                      connection.Open();
                      SqlCommand command = new SqlCommand("SELECT e.FirstName + ' ' + e.LastName AS DoctorName, " +
                          "p.FirstName + ' ' + p.LastName AS PatientName, " +
                          "o.Number AS OfficeNumber, " +
                          "c.Date, " +
                          "c.Time " +
                          "FROM CalendarEntity c " +
                          "JOIN Employees e ON e.Id = c.DoctorId " +
                          "JOIN MedicalVisit m ON m.ID = c.CalendarId " +
                          "JOIN Employees p ON p.Id = m.PatientID " +
                          "JOIN Offices o ON o.Id = c.OfficeId " +
                          "WHERE m.ID = @visitId", connection);
                      command.Parameters.AddWithValue("@visitId", visitId);
                      SqlDataReader reader = command.ExecuteReader();
                      if (reader.Read())
                      {
                          string doctorName = reader["DoctorName"].ToString();
                          string patientName = reader["PatientName"].ToString();
                          string officeNumber = reader["OfficeNumber"].ToString();
                          string date = reader["Date"].ToString();
                          string time = reader["Time"].ToString();

                          doctorNameTextBox.Text = doctorName;
                          patientNameTextBox.Text = patientName;
                          officeNumberTextBox.Text = officeNumber;
                          dateTextBox.Text = date;
                          timeTextBox.Text = time;
                      }
                      reader.Close();
                  }
              }
              catch (Exception ex)
              {
                  // Obsługa wyjątku - np. wyświetlenie komunikatu o błędzie
                  MessageBox.Show("Error: " + ex.Message);
              }



          }*/


        public void LoadDataIntoDataGridViewCalendar(DataGridView dataGridView, string tableName, DateTime comparisonDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {tableName} WHERE Date = @ComparisonDate"; // zapytanie SQL z warunkiem WHERE
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@ComparisonDate", comparisonDate);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable; // ustawienie źródła danych dla DataGridView

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas odczytu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
