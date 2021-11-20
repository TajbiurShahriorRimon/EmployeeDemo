using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;

namespace EmployeeDemo
{
    public partial class CreateEmployeeForm : Form
    {
        private OpenFileDialog openFileDialog;
        private string fileExtension;

        public CreateEmployeeForm()
        {
            InitializeComponent();
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            bool checkInputValidation = this.CheckValidation();

            if(checkInputValidation == true)
            {
                string gender = "";
                string name = this.nameTxt.Text;
                string email = this.emailTxt.Text;
                string password = this.passwordTxt.Text;                
                if (this.femaleRadioBtn.Checked)
                {
                    gender = this.femaleRadioBtn.Text;
                }
                else
                {
                    gender = this.maleRadioBtn.Text;
                }     
                string type = "Employee"; //When inserting, only type will be "Employee";
                double salary = Convert.ToDouble(this.salaryTxt.Text);

                //Get the file extension
                string dateTime = DateTime.Today.ToString("M_d_yyyy"); //Get Today's date in a format
                string date = DateTime.Now.ToString("HH_mm_ss_tt"); //Getting the time in a format
                //setting up the file path
                string imagePath = @"D:\c_sharpProject\EmployeeDemo\EmployeeDemo\Images\" + dateTime + "_" + date + this.fileExtension;
                
                int row = new Database().InsertData(salary, name, email, password, gender, type, imagePath);

                if(row > 0)
                {
                    //The file which is selected will have a copy and then paste the file image in the following give path
                    File.Copy(this.openFileDialog.FileName, imagePath);
                    MessageBox.Show("Successfully Inserted");

                    //After succesffuly insertion, UserHomeForm will be displayed.
                    new UserHomeForm().Show();
                    this.Hide();
                }
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            this.openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Supported files|*.jpg;*.jpeg;*.png";
            openFileDialog.ValidateNames = true;
            openFileDialog.Multiselect = false;

            //Following line exectues when the user selects a file from the dialog box.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Done", "Dialog");
                //Set the image in the picture box.
                this.pictureBox.Image = new Bitmap(openFileDialog.FileName);

                string filePath = openFileDialog.FileName;
                this.fileExtension = Path.GetExtension(filePath); //Get the file extension
            }
        }

        public bool CheckValidation()
        {
            //Check for input fields
            if (this.nameTxt.Text == "" || this.emailTxt.Text == "" || this.passwordTxt.Text == "" || this.salaryTxt.Text == "")
            {
                MessageBox.Show("Input fields cannot be empty");
                return false;
            }
            if (this.maleRadioBtn.Checked == false && this.femaleRadioBtn.Checked == false)
            {
                MessageBox.Show("Select Gender");
                return false;
            }
            //If photo is not selected then it will show a error message and then returns void
            if (this.pictureBox.Image == null)
            {
                MessageBox.Show("Select a photo");
                return false;
            }
            if (this.nameTxt.Text.Length > 50)
            {
                MessageBox.Show("Name cannot be greater than 50");
                return false;
            }
            if (this.emailTxt.Text.Length > 50)
            {
                MessageBox.Show("Email cannot be greater than 50");
                return false;
            }
            if (this.passwordTxt.Text.Length > 20)
            {
                MessageBox.Show("Password cannot be greater than 20");
                return false;
            }
            if (Regex.IsMatch(this.nameTxt.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Name must contain only alphabets");
                return false;
            }
            if (this.emailTxt.Text.Trim().EndsWith("."))
            {
                MessageBox.Show("Give a proper email address");
                return false;
            }
            else
            {
                try
                {
                    new MailAddress(this.emailTxt.Text);
                    //MessageBox.Show("Proper mail address");
                }
                catch
                {
                    MessageBox.Show("Give a proper email address");
                    return false;
                }
            }
            try
            {
                Convert.ToDouble(this.salaryTxt.Text);
            }
            catch
            {
                MessageBox.Show("Salary must be number");
                return false;
            }

            SqlDataReader data = new Database().CheckIfEmailExists(this.emailTxt.Text);

            //The following executes if there is alrady an existance of this email
            if (data.HasRows)
            {
                MessageBox.Show("Email already exists. Give a new email");
                return false;
            }

            //If Everything is validated properly then return true
            return true;
        }

        //Go to UserHomeForm
        private void moveToUserHomeForm_Click(object sender, EventArgs e)
        {
            new UserHomeForm().Show();
            this.Hide();
        }
    }    
}
