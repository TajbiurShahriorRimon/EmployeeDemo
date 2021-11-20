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
    public partial class UserHomeForm : Form
    {
        //For storing purpose of employee information
        public static string employeeType;
        public static int employeeId;

        private OpenFileDialog openFileDialog;
        private string fileExtension;
        private bool photoPathForDisplay;
        private Nullable <int> employeeIdForAction;

        public UserHomeForm()
        {
            InitializeComponent();
            if (UserHomeForm.employeeType == "Employee")
            {
                this.deleteEmployeeBtn.Visible = false;
            }

            this.UserFeatureVisibility();
            this.ShowData();
        }

        public UserHomeForm(int employeeId, string employeeType)
        {
            InitializeComponent();
            UserHomeForm.employeeId = employeeId;
            UserHomeForm.employeeType = employeeType;

            this.UserFeatureVisibility();
            this.ShowData();
        }

        //Display data in the data grid view
        public void ShowData()
        {
            //data will be shown in the data grid view based on the text written in the search text bar
            string dataString = this.searchEmployeeTxt.Text;
            SqlDataReader dataReader = new Database().GetAllEmployeeData(dataString);

            //If data found, then it is prepared to display in the data grid view.
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                //There will be multiple data with columns. But all columns values are not required in the data grid view.
                //Therefore the extra column values are ignored.
                this.EmployeeDataTable.AutoGenerateColumns = false;
                //Data assigined in the data grid view.
                this.EmployeeDataTable.DataSource = dataTable;
            }
            //Else If no data is found then the data grid view will be empty.
            else
            {
                this.EmployeeDataTable.DataSource = null;
            }
        }

        private void employeeUpdateBtn_Click(object sender, EventArgs e)
        {
            bool inputValidation = this.CheckInputValidation();
            int id = -1;

            if(inputValidation == true)
            {
                string path = "";
                SqlDataReader data = new Database().GetEmployeeData(this.employeeIdForAction.Value);

                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        path = data[7].ToString(); //Getting the file path from database, 8th column
                        id = Convert.ToInt32(data[0].ToString());
                    }
                }

                string name = this.nameTxt.Text;
                string email = this.emailTxt.Text;
                double salary = Convert.ToDouble(this.salaryTxt.Text);

                string gender = "";
                if (this.femaleRadioBtn.Checked)
                {
                    gender = this.femaleRadioBtn.Text;
                }
                else
                {
                    gender = this.maleRadioBtn.Text;
                }

                //Get the file extension
                string dateTime = DateTime.Today.ToString("M_d_yyyy"); //Get Today's date in a format
                string date = DateTime.Now.ToString("HH_mm_ss_tt"); //Getting the time in a format
                //setting up the file path
                string imagePath = @"D:\c_sharpProject\EmployeeDemo\EmployeeDemo\Images\" + dateTime + "_" + date + this.fileExtension;

                int row;
                if (this.photoPathForDisplay == true)
                {
                    //MessageBox.Show("Image selected");
                    row = new Database().UpdateEmployeeData(id, salary, name, email, gender, imagePath);

                    if (row > 0)
                    {
                        MessageBox.Show("Updated Successfully!");

                        this.SuccessfulOperation();

                        if (File.Exists(path))
                        {
                            //MessageBox.Show("Exists");
                            //Without the following line there will be a runtime error because the file is being used by this application
                            this.pictureBox.Image = null;

                            //Every method has memory allocation. We have to realease the memeory before deleting the file
                            GC.Collect(); //Without this line there will be a runtime error
                            GC.WaitForPendingFinalizers(); //Without this line there will be a runtime error
                            File.Delete(path);

                            //MessageBox.Show(this.openFileDialog.FileName);
                        }
                        //The file which is selected will have a copy and then paste the file image in the following given path
                        try
                        {
                            //Howerver if the user do not select any image file, then there is no need to work on the file, so
                            //a try catch block is required.
                            File.Copy(this.openFileDialog.FileName, imagePath);

                        }
                        catch { }
                    }
                }
                else
                {
                    //MessageBox.Show("Image not selected");
                    row = new Database().UpdateEmployeeData(id, salary, name, email, gender);
                    
                    if(row > 0)
                    {
                        MessageBox.Show("Updated Successfully!");
                        this.SuccessfulOperation();
                    }
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

                this.photoPathForDisplay = true; //Setting it to true because a photo is selected

                string filePath = openFileDialog.FileName;
                this.fileExtension = Path.GetExtension(filePath); //Get the file extension
            }
        }

        private void createEmpBtn_Click(object sender, EventArgs e)
        {            
            this.Hide();
            new CreateEmployeeForm().Show();
        }

        private void searchEmployeeTxt_TextChanged(object sender, EventArgs e)
        {
            this.ShowData();
        }

        /*private void EmployeeDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                MessageBox.Show("hello");
                DataGridViewRow row = this.EmployeeDataTable.Rows[e.RowIndex];

                MessageBox.Show(row.Cells["Id"].Value.ToString());
            }
        }*/

        //When user double click on e cell in Data grid view to display employee data in the update form
        private void EmployeeDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(this.EmployeeDataTable.CurrentRow.Cells[0].Value.ToString());
            //Converting string id to integer id.
            int id = Convert.ToInt32(this.EmployeeDataTable.CurrentRow.Cells[0].Value.ToString());
            //Assigning the id to employeeIdForUpdate because the following field variable is required for update or delete purpose.
            this.employeeIdForAction = id;

            SqlDataReader dataReader = new Database().GetEmployeeData(id);

            this.PopulateEmployeeData(dataReader);

            //If the uesr type is admin then Admin can delete or can edit the employee.
            if(UserHomeForm.employeeType == "Admin")
            {
                this.DisableEmployeeRegistrationForm();

                this.editEmployeeBtn.Enabled = true;
                this.employeeUpdateBtn.Enabled = false;

                //After selecting a row from grid view, it has to be checked if the selected row data is Admin's data or employee data
                //If the data is Admin data then delte button is disabled, because admin cant delete himself, admin can delete only
                //employee user type data
                bool checkAdmin = this.CheckIfAdmin(id);

                //If data user type is admin then delete button is disabled.
                if(checkAdmin == true)
                {
                    this.deleteEmployeeBtn.Enabled = false;
                }
                //Else If data user type is employee then delete button is enabled and admin has option to delete that employee.
                else
                {
                    this.deleteEmployeeBtn.Enabled = true;
                }
            }
        }

        //Display data in the employee update form
        public void PopulateEmployeeData(SqlDataReader dataReader)
        {
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    //Assigining data in the form text fields and radio button.
                    this.nameTxt.Text = dataReader[1].ToString();
                    this.emailTxt.Text = dataReader[2].ToString();
                    this.salaryTxt.Text = dataReader[5].ToString();

                    if(dataReader[4].ToString() == "Male")
                    {
                        this.maleRadioBtn.Select();
                    }
                    else if(dataReader[4].ToString() == "Female")
                    {
                        this.femaleRadioBtn.Select();
                    }

                    try
                    {
                        string s = dataReader[7].ToString();
                        Bitmap bitmap = new Bitmap(dataReader[7].ToString()); //Assigning the path in Bitmap Constructor
                        //Showing the picture in the picture box by the help of bitmap.
                        this.pictureBox.Image = bitmap;
                        //MessageBox.Show("Has image");
                    }
                    catch
                    {
                        //MessageBox.Show("No Image found");
                        this.pictureBox.Image = null;
                    }
                }
            }
        }

        public void UserFeatureVisibility()
        {
            if (UserHomeForm.employeeType == "Employee")
            {
                this.deleteEmployeeBtn.Visible = false;
                this.editEmployeeBtn.Visible = false;
                this.employeeUpdateBtn.Visible = false;
                this.createEmpBtn.Visible = false;
                this.searchEmployeeTxt.Visible = false;

            }
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            //When this button is clicked we have to enable the registration for of employee for update purpose.
            this.EnableEmployeeRegistrationForm();

            //If this button is clicked then the following buttons will be disabled
            this.editEmployeeBtn.Enabled = false;
            this.employeeUpdateBtn.Enabled = true;
            this.deleteEmployeeBtn.Enabled = false;
        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            if(this.employeeIdForAction == null)
            {
                MessageBox.Show("Null");
            }

            //To delete the image path which is stored in the database is required.
            SqlDataReader data = new Database().GetEmployeeData(this.employeeIdForAction.Value);
            
            if (data.HasRows)
            {
                while (data.Read())
                {
                    imagePath = data[7].ToString(); //Getting the file path from database, 8th column
                }
            }

            //MessageBox.Show(this.employeeIdForAction.ToString());

            //Again assigining a new reference. Without this there will be a run-time error since another reference was assigned before.
            int row = new Database().DeleteData(this.employeeIdForAction.Value);

            if(row > 0)
            {
                if (File.Exists(imagePath))
                {
                    //MessageBox.Show("Exists");
                    //Without the following line there will be a runtime error because the file is being used by this application
                    this.pictureBox.Image = null;

                    //Every method has memory allocation. We have to realease the memeory before deleting the file
                    GC.Collect(); //Without this line there will be a runtime error
                    GC.WaitForPendingFinalizers(); //Without this line there will be a runtime error
                    File.Delete(imagePath);
                }
                MessageBox.Show("Deleted Successfully");
                this.SuccessfulOperation();
            }
        }

        private void goToChangePasswordForm_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm().Show();
            this.Hide();
        }

        public void DisableEmployeeRegistrationForm()
        {
            this.nameTxt.Enabled = false;
            this.emailTxt.Enabled = false;
            this.salaryTxt.Enabled = false;
            this.browseBtn.Enabled = false;
            this.maleRadioBtn.Enabled = false;
            this.femaleRadioBtn.Enabled = false;
            this.browseBtn.Enabled = false;
            //this.pictureBox.Image = null;

            //this.photoPathForDisplay = false;
        }

        public void EnableEmployeeRegistrationForm()
        {
            this.nameTxt.Enabled = true;
            this.emailTxt.Enabled = true;
            this.salaryTxt.Enabled = true;
            this.browseBtn.Enabled = true;
            this.maleRadioBtn.Enabled = true;
            this.femaleRadioBtn.Enabled = true;
            this.browseBtn.Enabled = true;
        }

        public bool CheckInputValidation()
        {
            //Check for input fields
            if (this.nameTxt.Text == "" || this.emailTxt.Text == "" || this.salaryTxt.Text == "")
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

            //We have to check if the email given is a duplicate or not. Duplicate email is not accepted.
            SqlDataReader data = new Database().CheckIfEmailExistsForUpdate(this.employeeIdForAction.Value, this.emailTxt.Text);

            //The following executes if there is alrady an existance of this email
            if (data.HasRows)
            {
                MessageBox.Show("Email already exists. Give a new email");
                return false;
            }

            return true;
        }

        public void ClearUpdateForm()
        {
            this.nameTxt.Text = "";
            this.emailTxt.Text = "";
            this.salaryTxt.Text = "";
            this.maleRadioBtn.Checked = false;
            this.femaleRadioBtn.Checked = false;
            this.pictureBox.Image = null;

            this.employeeIdForAction = null;
        }

        public void SuccessfulOperation()
        {
            this.ShowData();

            this.editEmployeeBtn.Enabled = false;
            this.deleteEmployeeBtn.Enabled = false;
            this.employeeUpdateBtn.Enabled = false;

            this.DisableEmployeeRegistrationForm();
            this.ClearUpdateForm();

            this.photoPathForDisplay = false;
        }

        //This method takes data and retuts boolean value if the data selected in data grid view user type is admin or employee
        public bool CheckIfAdmin(int id)
        {
            SqlDataReader data = new Database().GetEmployeeData(id);
            if (data.HasRows)
            {
                while (data.Read())
                {
                    //if data is admin then return true
                    if(data[6].ToString() == "Admin")
                    {
                        return true;
                    }
                }
            }

            //now since data user type is not admin, rather employee, return false.
            return false;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
