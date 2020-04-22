using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StartDB.Models;

namespace StartDB.Service.ValidationService
{
    public class ValidationService : IValidationService
    {
        public bool ValidateUser(LoginModel credentials)
        {
            string connectionString = @"Data Source=DESKTOP-U722MD5\SQLEXPRESS;Initial Catalog=StartDB;Integrated Security=True";
            string queryString = $"SELECT * from Users WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@username", credentials.Username);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return true;
            }  
        }
    }
}