using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace YCW_DataManagement
{
    public class Initializer : Adapter, IDataInitializer
    {

        #region Main Database Methods
        public void BuildDatabase() //Builds Database
        {
            CreateDatabase();
            if (DoTablesExists() == false)  // Check if tables exist already in database
            {
                CreateTables();
                SeedDatabase();
            }
        }

        // Creates all the tables
        private void CreateTables() 
        {
            CreateCustomerTable();
            CreateToolsTable();
            CreateRentalsTable();
        }
        
        // Fills tables with dummy data for testing purposes
        public void SeedDatabase()
        {
            SeedCustomerTable();
            SeedToolsTable();
            SeedRentalsTable();
        }

        #endregion

        #region Create Tables

        // Method to send SQL Query to create tables
        private void CreateNewTables(string tableName, string structure)
        {
            string sql = $"CREATE TABLE {tableName} ({structure})";
            using (var connection = Helper.CreateDatabaseConnection())
            {
                try
                {
                    connection.Execute(sql);
                }
                
                catch (Exception e)
                {

                    Console.WriteLine(e.ToString());
                }
            }
        }

        // Various table schemas to send to method above
        private void CreateCustomerTable()
        {
            string tableName = "Customers";
            
            string structure = "CustomerID int IDENTITY (1,1) PRIMARY KEY, " +
                               "Name VARCHAR(50) NOT NULL, " +
                               "Surname VARCHAR(50) NOT NULL, " +
                               "Phone VARCHAR(20) NOT NULL";
            CreateNewTables(tableName, structure);
        }

        private void CreateToolsTable()
        {
            string tableName = "Tools";
            
            string structure = "ToolID int IDENTITY (1,1) PRIMARY KEY, " +
                               "ToolName VARCHAR(50) NOT NULL, " +
                               "ToolBrand VARCHAR(50) NOT NULL, " +
                               "ToolCondition VARCHAR(20) NOT NULL, " +
                               "ToolStatus VARCHAR(20) NOT NULL, " +
                               "RentStatus bit NOT NULL, " +
                               "Notes VARCHAR(100) NULL ";
            CreateNewTables(tableName, structure);
        }

        private void CreateRentalsTable()
        {
            string tableName = "Rentals";
            string structure = "RentalID int IDENTITY (1,1) PRIMARY KEY, " +
                               "CustomerID int NOT NULL, " +
                               "ToolID int NOT NULL, " +
                               "DateRented DATETIME NOT NULL, " +
                               "DateReturned DATETIME NULL, " +
                               "Notes VARCHAR(50) NULL, " +
                               "FOREIGN KEY(CustomerID) REFERENCES Customers (CustomerID), " +
                               "FOREIGN KEY(ToolID) REFERENCES Tools (ToolID) ";
            CreateNewTables(tableName, structure);
        }

        #endregion

        #region Database Building

        // Actually creates database
        public void CreateDatabase()
        {
            
            SqlConnection connection = Helper.CreateDatabaseConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                string connectionString = $"Data Source = {connection.DataSource}; " +
                                          $"Integrated Security = True";
                string sql = $"IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = '{connection.Database}' ) " +
                             $"CREATE DATABASE {connection.Database}";
                using (SqlConnection connServer = new SqlConnection(connectionString))
                {
                    using (command = new SqlCommand(sql, connServer))
                    {
                        if (connServer.State == System.Data.ConnectionState.Closed)
                        {
                            connServer.Open();
                        }
                        command.ExecuteNonQuery();
                        connServer.Close();
                    }
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.ToString());
            }
        }

        // Check if tables exist
        private bool DoTablesExists()
        {
            var connection = Helper.CreateDatabaseConnection();

            string sql = $"SELECT COUNT(*) FROM {connection.Database}.INFORMATION_SCHEMA.TABLES " +
                         $"WHERE TABLE_TYPE = 'BASE TABLE'";
            using (connection)
            {
                //an error happens here where it doesn't connect to the database
                int num = connection.QuerySingle<int>(sql);
                if (num > 0)
                {
                    return true;
                }
                return false;
            }

        }

        // Methods to fill database with provided dummy data
        private void SeedCustomerTable()
        {
            List<Customer> newCustomers = new List<Customer>();
            newCustomers.Add(new Customer { Name = "Bob", Surname = "Jane", Phone = "0412764423" });
            newCustomers.Add(new Customer { Name = "Zoe", Surname = "Smith", Phone = "0402743423" });
            newCustomers.Add(new Customer { Name = "Nick", Surname = "Burton", Phone = "0442734423" });
            newCustomers.Add(new Customer { Name = "Matt", Surname = "Bowman", Phone = "0412312122" });
            newCustomers.Add(new Customer { Name = "Ryan", Surname = "Skylar", Phone = "0428378282" });
            newCustomers.Add(new Customer { Name = "Maddy", Surname = "Ripps", Phone = "0423821712" });
            newCustomers.Add(new Customer { Name = "Meg", Surname = "Narayan", Phone = "0485827371" });
            newCustomers.Add(new Customer { Name = "Kaleb", Surname = "Durgun", Phone = "2093874821" });
            newCustomers.Add(new Customer { Name = "Kane", Surname = "Makas", Phone = "0432828392" });
            newCustomers.Add(new Customer { Name = "Muhammad", Surname = "Ali", Phone = "0428382812" });

            foreach (var cust in newCustomers)
            {
                AddNewCustomer(cust);
            }
        }

        private void SeedToolsTable()
        {
            List<Tool> newTools = new List<Tool>();
            newTools.Add(new Tool { ToolName = "Vise Grip Locking Plier", ToolBrand = "Irwin", ToolCondition = "Usuable", ToolStatus = "Active", RentStatus = true, Notes = "" });
            newTools.Add(new Tool { ToolName = "3inch  G Clamp", ToolBrand = "Irwin", ToolCondition = "Usuable", ToolStatus = "Active", RentStatus = true, Notes = "" });
            newTools.Add(new Tool { ToolName = "10inch G Clamp", ToolBrand = "Irwin", ToolCondition = "Usuable", ToolStatus = "Active", RentStatus = true, Notes = "" });
            newTools.Add(new Tool { ToolName = "6mm Chisel", ToolBrand = "Trojan", ToolCondition = "Broken", ToolStatus = "Active", RentStatus = false, Notes = "Bent" });
            newTools.Add(new Tool { ToolName = "Compass Saw", ToolBrand = "Stanley", ToolCondition = "Broken", ToolStatus = "Retired", RentStatus = false, Notes = "" });
            newTools.Add(new Tool { ToolName = "30mm Chisel", ToolBrand = "Stanley", ToolCondition = "Usuable", ToolStatus = "Retired", RentStatus = false, Notes = "" }); ;
            newTools.Add(new Tool { ToolName = "Epoxy Frame Hacksaw", ToolBrand = "Eclipse", ToolCondition = "Broken", ToolStatus = "Retired", RentStatus = false, Notes = "Rusted" });
            newTools.Add(new Tool { ToolName = "Hand Saw", ToolBrand = "Eclipse", ToolCondition = "Usuable", ToolStatus = "Active", RentStatus = true, Notes = "" });
            newTools.Add(new Tool { ToolName = "Hammer", ToolBrand = "Irwin", ToolCondition = "Usuable", ToolStatus = "Active", RentStatus = false, Notes = "" });
            newTools.Add(new Tool { ToolName = "Utility Knife", ToolBrand = "Eclipse", ToolCondition = "Usuable", ToolStatus = "Active", RentStatus = true, Notes = "" });
            newTools.Add(new Tool { ToolName = "Drill", ToolBrand = "Eclipse", ToolCondition = "Usuable", ToolStatus = "Retired", RentStatus = false, Notes = "Too inefficient" });
            newTools.Add(new Tool { ToolName = "Shovel", ToolBrand = "Irwin", ToolCondition = "Usuable", ToolStatus = "Active", RentStatus = false, Notes = "" });


            foreach (var tool in newTools)
            {
                AddNewTool(tool);
            }
        }

        private void SeedRentalsTable()
        {
            List<Rental> newRents = new List<Rental>();
            newRents.Add(new Rental(1, 1, System.DateTime.Now.AddDays(-2).AddHours(3)));
            newRents.Add(new Rental(1, 2, System.DateTime.Now.AddDays(-15).AddHours(1)));
            newRents.Add(new Rental(1, 3, System.DateTime.Now.AddDays(-7).AddHours(6)));
            newRents.Add(new Rental(5, 8, System.DateTime.Now.AddDays(-4).AddHours(4)));
            newRents.Add(new Rental(8, 10, System.DateTime.Now.AddDays(-10).AddHours(6)));
            newRents.Add(new Rental(1, 7, System.DateTime.Now.AddDays(-20).AddHours(6), System.DateTime.Now.AddDays(-5).AddHours(1), "Rusted"));
            newRents.Add(new Rental(8, 4, System.DateTime.Now.AddDays(-10).AddHours(6), System.DateTime.Now.AddDays(-17).AddHours(2), "Bent"));
            newRents.Add(new Rental(3, 11, System.DateTime.Now.AddDays(-10).AddHours(6), System.DateTime.Now.AddDays(-31).AddHours(4), "Too inefficient"));




            foreach (var rent in newRents)
            {
                AddNewRental(rent);
            }
        }
        #endregion
    }
}
