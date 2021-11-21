using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class Database
    {
        private SqlConnection sqlConnection;
        private string connectionString = "Data Source=.;Initial Catalog=UserEmp;Integrated Security=True";
        private SqlCommand sqlCommand; //Used to execute the query

        public Database()
        {
            sqlConnection = new SqlConnection(this.connectionString);
            sqlConnection.Open();
        }

        public SqlDataReader CheckIfUserExists(string email, string password)
        {
            string query = $@"Select * from Employees where email = '{email}' COLLATE Latin1_General_CS_AS
                                and password = '{password}' COLLATE Latin1_General_CS_AS";
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);

            SqlDataReader data = sqlCommand.ExecuteReader(); //Execute the query, then it returns data.

            return data;
        }

        public int InsertData(double salary, params string[] data)
        {
            string query = $@"INSERT INTO Employees (Name, Email, Password, Gender, Type, Salary, Image)
                                values ('{data[0]}', '{data[1]}', '{data[2]}', '{data[3]}', '{data[4]}', {salary}, '{data[5]}')";
            //Binding into sqlCommand.
            sqlCommand = new SqlCommand(query, this.sqlConnection);
            int rows = sqlCommand.ExecuteNonQuery(); //Executing the query, then it result number of rows affected.
            return rows;
        }

        //For Update, Insert employee, we have to check if the email given in the text field is duplicate or not
        public SqlDataReader CheckIfEmailExists(string email)
        {
            string query = $@"Select email from Employees where email = '{email}' COLLATE Latin1_General_CS_AS";
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);

            SqlDataReader data = sqlCommand.ExecuteReader(); //Execute the query, then it returns data.

            return data;
        }

        public SqlDataReader GetAllEmployeeData(string dataString)
        {
            string query = $"Select Id, Name as txtName, Email, Password, Gender, Type from Employees where Name like '%{dataString}%'";
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);
            SqlDataReader data = sqlCommand.ExecuteReader();

            return data;
        }

        //Get Single Employee Data.
        public SqlDataReader GetEmployeeData(int id)
        {
            string query = $"Select * from Employees where Id = {id}";
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);
            SqlDataReader data = sqlCommand.ExecuteReader();

            return data;
        }

        public SqlDataReader GetPresentPassword(int id)
        {
            string query = $"Select Password from Employees where Id = {id}";
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);
            SqlDataReader data = sqlCommand.ExecuteReader();

            return data;
        }

        public int UpdatePassword(int id, string password)
        {
            string query = $"Update Employees Set Password = '{password}' where Id = {id}";
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);

            int row = sqlCommand.ExecuteNonQuery();
            return row;
        }

        public int UpdateEmployeeData(int id, double salary, params string[] data)
        {
            string query = "";
            if (data.Length == 3)
            {
                query = $@"Update Employees Set Name = '{data[0]}', Email = '{data[1]}', Gender = '{data[2]}',
                                Salary = {salary} where Id = {id}";
            }
            else
            {
                query = $@"Update Employees Set Name = '{data[0]}', Email = '{data[1]}', Gender = '{data[2]}',
                                Salary = {salary}, Image = '{data[3]}' where Id = {id}";
            }
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);

            int row = sqlCommand.ExecuteNonQuery();
            return row;
        }

        public SqlDataReader CheckIfEmailExistsForUpdate(int id, string email)
        {
            string query = $@"Select email from Employees where email = '{email}' COLLATE Latin1_General_CS_AS and Id != {id}";
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);

            SqlDataReader data = sqlCommand.ExecuteReader(); //Execute the query, then it returns data.

            return data;
        }

        public int DeleteData(int id)
        {
            string query = $"DELETE FROM Employees where id = {id}";
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);
            int rows = sqlCommand.ExecuteNonQuery(); //Executing the query, then it result number of rows affected.

            return rows;
        }

        public int InsertNotice(string query)
        {
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);
            int row = sqlCommand.ExecuteNonQuery();
            return row;            
        }

        public SqlDataReader ReadNoticeData(string query)
        {
            this.sqlCommand = new SqlCommand(query, this.sqlConnection);
            SqlDataReader data = this.sqlCommand.ExecuteReader();

            return data;
        }

    }
}
