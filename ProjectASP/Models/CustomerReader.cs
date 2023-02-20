using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjectASP.Models
{
    public class CustomerReader
    {
        string connectionString = "Data Source=DESKTOP-IG5DCG1;Initial Catalog=AdventureWorksLT2019;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Customer> GetCustomers()
        { 
        SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT c.FirstName, c.MiddleName, c.LastName, c.Suffix, c.CompanyName,a.AddressLine1, a.City\r\nFROM SalesLT.Customer c\r\nINNER JOIN SalesLT.CustomerAddress ca ON c.CustomerID = ca.CustomerID\r\nINNER JOIN SalesLT.Address a ON ca.AddressID = a.AddressID;";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> result = new List<Customer>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        FirstName = reader["FirstName"] is DBNull ? null:reader["FirstName"].ToString(),
                        MiddleName = reader["MiddleName"] is DBNull ? null : reader["MiddleName"].ToString(),
                        LastName =reader["LastName"] is DBNull ? null : reader["LastName"].ToString(),
                        Suffix = reader["Suffix"] is DBNull ? null : reader["Suffix"].ToString(),
                        CompanyName = reader["CompanyName"] is DBNull ? null : reader["CompanyName"].ToString(),
                        AddressLine = reader["AddressLine1"] is DBNull ? null : reader["AddressLine1"].ToString(),
                        City = reader["City"] is DBNull ? null : reader["City"].ToString(),
                    };
                    result.Add(customer);
                }
            }
           reader.Close();
            connection.Close();
            return result;
        }
    }
}
