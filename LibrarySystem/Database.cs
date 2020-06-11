/* 1. connect
2. create database if not exists
3. select database
4. create table if not exists */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Net;

namespace LibrarySystem {
    class Database {
        static MySql.Data.MySqlClient.MySqlConnection conn;
        static MySql.Data.MySqlClient.MySqlCommand cmd;

        static string createBookTable = "CREATE TABLE Book(Title varchar(50),"
                                        + "AuthorFirstName varchar(50),"
                                        + "AuthorLastName varchar(50),"
                                        + "Year int,"
                                        + "ID int NOT NULL,"
                                        + "Location varchar(50),"
                                        + "Avaliable boolean,"
                                        + "Fiction boolean,"
                                        + "CheckoutDate datetime,"
                                        + "ReturnDate datetime,"
                                        + "PRIMARY KEY (Id)"
                                        + ");";

        static string createBorrowerTable = "CREATE TABLE Borrower(FirstName varchar(50)," 
                                        + "AuthorFirstName varchar(50)," 
                                        + "LastName varchar(50),"
                                        + "Id int NOT NULL,"
                                        + "Dob datetime,"
                                        + "Restriction boolean,"
                                        + "NumReturnedLate int,"
                                        + "PRIMARY KEY (Id)"
                                        + ");";

        static string createCheckedOutTable = "CREATE TABLE CheckedOutBooks(BookId int,"
                                        + "BorrowerId int,"
                                        + "FOREIGN KEY(BookId) REFERENCES Book(Id),"
                                        + "FOREIGN KEY(BorrowerId) REFERENCES Borrower(Id)"
                                        + ");";
        public static string createDatabase(string ipAddress, int port, string username, string password, string databaseName) {
            // example connection string format: server=127.0.0.1:12345;uid=root;pwd=12345;database=exampledatabase
            conn.ConnectionString = "server=" + ipAddress + ":" + port + ";" + "uid=" + username + ";" + "pwd=" + password + ";" + "database=" + databaseName;
            
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            // cmd = new MySql.Data.MySqlClient.MySqlCommand();

            MySqlCommand cmd;
            try {
                conn.Open();

                cmd = new MySqlCommand(createBookTable, conn);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand(createBorrowerTable, conn);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand(createCheckedOutTable, conn);
                cmd.ExecuteNonQuery();

                // conn.Close();
                return "Database creation successful";
            } catch (MySql.Data.MySqlClient.MySqlException ex) {
                return "Error " + ex.Number + " has occurred: " + ex.Message + "Error";
            }
        }
        public static string insertBook(string title, string authorFirstName, string authorLastName, int year, int id, 
            string location, bool avaliable, bool fiction, DateTime checkoutDate, DateTime returnDate) {
            try {
                conn.Open();

                cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Book VALUES(@Title, @AuthorFirstName, @AuthorLastName, @Year, @Id, @Location, @Avaliable, @Fiction, @CheckoutDate, @ReturnDate)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@AuthorFirstName", authorFirstName);
                cmd.Parameters.AddWithValue("@AuthorLastName", authorLastName);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@Avaliable", avaliable);
                cmd.Parameters.AddWithValue("@Fiction", fiction);
                cmd.Parameters.AddWithValue("@CheckoutDate", checkoutDate);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate);

                cmd.ExecuteNonQuery();
                return "Database insert successful";
            } catch (MySql.Data.MySqlClient.MySqlException ex) {
                return "Error " + ex.Number + " has occurred: " + ex.Message + "Error";
            }
        }
        public static string insertBorrower(string firstName, string lastName, int id, DateTime dob, bool restriction, int numReturnedLate) {
            try {
                conn.Open();

                cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO Book VALUES(@FirstName, @LastName, @Id, @Dob, @Restriction, @NumReturnedLate)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Dob", dob);
                cmd.Parameters.AddWithValue("@Restriction", restriction);
                cmd.Parameters.AddWithValue("@NumReturnedLate", numReturnedLate);
                cmd.ExecuteNonQuery();
                return "Database insert successful";
            } catch (MySql.Data.MySqlClient.MySqlException ex) {
                return "Error " + ex.Number + " has occurred: " + ex.Message + "Error";
            }
        }
        public static string updateBook() {
            return "";
        }
        public static string updateBorrower() {
            return "";
        }
        public static string queryBook() {
            return "";
        }
        public static string queryBorrower() {
            return "";
        }
    }
}
