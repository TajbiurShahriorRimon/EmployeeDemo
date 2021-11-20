using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDemo
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }        

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //Checking if any input field is empty or not
            if(this.emailTxt.Text == "" || this.passwordTxt.Text == "")
            {
                //If empty, a message is shown.
                MessageBox.Show("Fields cannot be empty");
                return;
            }
            Database database = new Database();

            string userEmail = this.emailTxt.Text;
            string userPassword = this.passwordTxt.Text;

            string employeeType = "";
            int employeeId = -1;

            SqlDataReader data = database.CheckIfUserExists(userEmail, userPassword);
            //If there is a user exists then following line executes.
            if (data.HasRows)
            {
                while (data.Read())
                {
                    employeeId = Convert.ToInt32(data[0]);
                    employeeType = data[6].ToString();
                }
                //MessageBox.Show("user exists");
                UserHomeForm userHomeForm = new UserHomeForm(employeeId, employeeType);
                this.Hide();//Hides the present Window
                userHomeForm.Show();
            }
            //If no data found then following line executes
            else
            {
                MessageBox.Show("Email and Password did not match. Try Again!");
            }
        }
    }
}
