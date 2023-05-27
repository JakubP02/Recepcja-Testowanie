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

                    dataGridView.Columns["Id"].Visible = false;

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


        /* public void LoadDataIntoDataGridViewCalendar(DataGridView dataGridView, string tableName, DateTime comparisonDate)
         {
             try
             {
                 using (SqlConnection connection = new SqlConnection(connectionString))
                 {
                     connection.Open();

                     string query = $"SELECT * FROM {tableName} WHERE Date = @ComparisonDate"; 
                     SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                     dataAdapter.SelectCommand.Parameters.AddWithValue("@ComparisonDate", comparisonDate);

                     DataTable dataTable = new DataTable();
                     dataAdapter.Fill(dataTable);

                     dataGridView.DataSource = dataTable;
                     dataGridView.Columns["Id"].Visible = false;

                     connection.Close();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Wystąpił błąd podczas odczytu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
        */

        public void LoadDataIntoDataGridViewCalendar(DataGridView dataGridView, string tableName, DateTime comparisonDate, int doctorId )
        {
           
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query;
                    SqlCommand command;

                    if (doctorId != 0)
                    {
                        query = $"SELECT * FROM {tableName} WHERE Date = @ComparisonDate AND DoctorId = @DoctorId";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DoctorId", doctorId);
                    }
                    else
                    {

                        query = $"SELECT * FROM {tableName} WHERE Date = @ComparisonDate";
                        command = new SqlCommand(query, connection);
                    }

                    command.Parameters.AddWithValue("@ComparisonDate", comparisonDate);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                    dataGridView.Columns["Id"].Visible = false;
                    dataGridView.Columns["DoctorId"].Visible = false;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas odczytu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public string GetPatientEmail(string pesel)
        {
            string email = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Emailadress FROM Patients WHERE Pesel = @Pesel";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Pesel", pesel);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        email = reader["Emailadress"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas odczytu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return email;
        }


        public void SearchDataInView(string searchText, string viewName, DataGridView dataGridView, string columnName)
        {
            try
            {
                connection.Open();

                string query = $"SELECT * FROM {viewName} WHERE {columnName} = @SearchText";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", searchText);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                    dataGridView.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        public void UpdateCalendarEntity(int entityId)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UpdateCalendarEntity", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@EntityId", entityId);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
             
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public int GetPatientIdByPesel(string pesel)
        {
            int patientId = -1;

            try
            {
                connection.Open();
                string query = "SELECT ID FROM Patients WHERE Pesel = @Pesel";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Pesel", pesel);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    patientId = Convert.ToInt32(reader["ID"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return patientId;
        }



        public void GetDoctorsByPatientId(int patientId, DataGridView dataGridView)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM GetDoctorsByPatientId(@PatientId)", connection);
                command.Parameters.AddWithValue("@PatientId", patientId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable result = new DataTable();
                adapter.Fill(result);

                dataGridView.DataSource = result;
                dataGridView.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }




    }







}



