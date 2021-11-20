using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCW_DataManagement
{
    public class Adapter
    {
        #region Customer
        //SQL Query to Retrieve all customer entries
        public List<Customer> GetAllCustomers()
        {
            string sql = "SELECT * FROM Customers";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<Customer>(sql).ToList();
            }
        }
        //SQL Query to Retrieve a single customer entry
        public Customer GetSingleCustomerDetails(int id)
        {
            string sql = $"SELECT * FROM Customers WHERE CustomerID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.QuerySingle<Customer>(sql);
            }
        }
        //SQL Query to add new customer
        public void AddNewCustomer(Customer newCustomer)
        {
            string sql = "INSERT INTO Customers " +
                         "(Name,Surname,Phone) " +
                         "VALUES (@Name,@Surname,@Phone)";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, newCustomer);
            }
        }
        //SQL Query to save existing customer
        public void SaveExistingCustomer(Customer updatedCustomer)
        {
            string sql = "UPDATE Customers SET " +
                         "Name = @Name, Surname = @Surname, " +
                         "Phone = @Phone " +
                         $"WHERE CustomerID = {updatedCustomer.CustomerID}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, updatedCustomer);
            }
        }
        //SQL Query to delete a single customer
        public void DeleteSingleCustomer(int id)
        {
            string sql = $"DELETE FROM Customers WHERE CustomerID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql);
            }
        }
        #endregion

        #region Tools
        // SQL Query to add new tool
        public void AddNewTool(Tool newTool)
        {
            string sql = "INSERT INTO Tools " +
                         "(ToolName, ToolBrand, ToolCondition, ToolStatus, RentStatus, Notes) " +
                         "VALUES (@ToolName, @ToolBrand, @ToolCondition, @ToolStatus, @RentStatus, @Notes)";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, newTool);
            }
        }
        // SQL Query to retrieve all tools
        public List<Tool> GetAllTools()
        {
            string sql = "SELECT * FROM Tools";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<Tool>(sql).ToList();
            }
        }
        // SQL Query to retrieve a single tool's details
        public Tool GetSingleToolDetails(int id)
        {
            string sql = $"SELECT * FROM Tools WHERE ToolID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.QuerySingle<Tool>(sql);
            }
        }
        // SQL Query to save an existing tool's details and update database
        public void SaveExistingTool(Tool updatedTool)
        {
            string sql = "UPDATE Tools SET " +
                         "ToolName = @ToolName, ToolBrand = @ToolBrand, " +
                         "ToolCondition = @ToolCondition, ToolStatus = @ToolStatus, RentStatus = @RentStatus, Notes = @Notes " +
                         $"WHERE ToolID = {updatedTool.ToolID}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, updatedTool);
            }
        }
        // SQL Query to delete a single tool
        public void DeleteSingleTool(int id)
        {
            string sql = $"DELETE FROM Tools WHERE ToolID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql);
            }
        }
        #endregion

        #region Rentals
        // SQL Query to add new rental
        public void AddNewRental(Rental newRental)
        {
            
            string sql = "INSERT INTO Rentals " +
                         "(CustomerID, ToolID, DateRented, DateReturned, Notes) " +
                         "VALUES (@CustomerID, @ToolID, @DateRented, @DateReturned, @Notes)";

            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql, newRental);
            }
        }

        // SQL Query to retrieve all rentals for view mode
        public List<RentalView> GetAllRentals()
        {
            string sql = "SELECT Rentals.RentalID, Customers.Name, Customers.Surname, Tools.Notes, " +
                         "Tools.ToolName, Tools.ToolBrand, Rentals.DateRented, Rentals.DateReturned " +
                         "FROM Rentals " +
                         "INNER JOIN " +
                         "Customers ON Rentals.CustomerID = Customers.CustomerID " +
                         "INNER JOIN " +
                         "Tools ON Rentals.ToolID = Tools.ToolID ";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<RentalView>(sql).ToList();
            }
        }

        // SQL Query to retrieve all rentals for a specific customer
        public List<RentalView> GetAllRentals(int id)
        {
            string sql = "SELECT Rentals.RentalID, Customers.Name, Customers.Surname, Tools.Notes, " +
                         "Tools.ToolName, Tools.ToolBrand, Rentals.DateRented, Rentals.DateReturned " +
                         "FROM Rentals " +
                         "INNER JOIN " +
                         "Customers ON Rentals.CustomerID = Customers.CustomerID " +
                         "INNER JOIN " +
                         "Tools ON Rentals.ToolID = Tools.ToolID " +
                         $"WHERE Rentals.CustomerID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.Query<RentalView>(sql).ToList();
            }
        }


        // SQL Query to retrieve a single rental's details
        public Rental GetSingleRentalDetails(int id)
        {
            string sql = $"SELECT * FROM Rentals WHERE RentalID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                return connection.QuerySingle<Rental>(sql);
            }
        }

        
         //SQL Query to delete a single rental
        public void DeleteSingleRental(int id)
        {
            string sql = $"DELETE FROM Rentals WHERE RentalID = {id}";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                connection.Execute(sql);
            }
        }
        #endregion
    }
}
