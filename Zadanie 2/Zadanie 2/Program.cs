using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace P4___2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30;
            Encrypt =False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";





            using (SqlConnection connection =
            new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Proszę podać id Regionu");
                var id = Console.ReadLine();
                Console.WriteLine("Proszę podać Nazwę Regionu");
                var idr = Console.ReadLine();
                // Create the Command and Parameter objects.
                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                // dodanie systemu query dodanie regioonu przez użytkownika   
                var queryString = "INSERT INTO Region VALUES(@id, @regionName);" +
                "SELECT * FROM Region";
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("regionName", idr);
                var sqlOutput = command.ExecuteNonQuery();
                Console.WriteLine($"Affected rows: {sqlOutput}");
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader[0]} | Value: {reader[1]}");
                }
            }

        }
        }
    }
