using Recepcja;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Xunit;

namespace RecepcjaTests
{
    public class DatabaseConnectionTests
    {
        private const string TestConnectionString = "Data Source=localhost;Initial Catalog=testowanie;Integrated Security=True;";

   
        [Fact]
        public void TestUpdateDataInDatabase()
        {
            // Arrange
            using (SqlConnection connection = new SqlConnection(TestConnectionString))
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                string tableName = "TestTable";
                string[] columnNames = { "Column1", "Column2" };
                string[] columnValues = { "Value1", "Value2" };
                string condition = "Id = 1";

                // Act
                databaseConnection.UpdateDataInDatabase(tableName, columnNames, columnValues, condition);

                // Assert
                // Assert the expected result after updating the data in the database
                // For example, you can retrieve the updated data and check if the values are updated correctly
            }
        }

        [Fact]
        public void TestInsertDataToDatabase()
        {
            // Arrange
            using (SqlConnection connection = new SqlConnection(TestConnectionString))
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                string tableName = "TestTable";
                string[] columnNames = { "Column1", "Column2" };
                string[] columnValues = { "Value1", "Value2" };

                // Act
                databaseConnection.InsertDataToDatabase(tableName, columnNames, columnValues);

                // Assert
                // Assert the expected result after inserting the data into the database
                // For example, you can retrieve the inserted data and check if the values are inserted correctly
            }
        }

        [Fact]
        public void TestExecuteQuery()
        {
            // Arrange
            using (SqlConnection connection = new SqlConnection(TestConnectionString))
            {
                DatabaseConnection databaseConnection = new DatabaseConnection();
                string query = "SELECT * FROM TestTable";

                // Act
                DataTable result = databaseConnection.ExecuteQuery(query);

                // Assert
                Assert.NotNull(result);
                // Assert other expectations based on the executed query and the expected result
            }
        }

        
    }
}
