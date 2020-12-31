using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarryGO.Classes;

namespace CarryGO
{
    public partial class AddEmployeePage : Form
    {
        Employee employee = new Employee();
        public AddEmployeePage()
        {
            InitializeComponent();

        }

        private bool ValidateEmail(string email)
        {
            try
            {
                var emailAddress = new System.Net.Mail.MailAddress(email);
                return emailAddress.Address == email;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            //Add new employe to Employee table
            try
            {
                errorLabel.Text = " ";
                string name = FirstNameBox.Text.Trim();
                string lastname = LastNameBox.Text.Trim();
                object gender = GenderComboBox.SelectedValue;
                string email = EmailBox.Text.Trim();
                int password = int.Parse(PasswordBox.Text.Trim().ToString());
                string address = AddressBox.Text.Trim();
                long phone = long.Parse(PhoneBox.Text.Trim().ToString());
                object departmentID = DepartmentComboBox.SelectedValue;
               

                if (!ValidateEmail(email))
                {
                    errorLabel.Text = "Please enter correct e-mail!";
                    EmailBox.Focus();
                    errorLabel.ForeColor = Color.Red;
                    return;
                }

                employee.Add(name, lastname, gender, email, password, address, phone, departmentID);
                errorLabel.Text = "Employee successfully added";
                errorLabel.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                errorLabel.Text = " ";
                //errorLabel.Text = "An error occured while adding a new employee";
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AddEmployeePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carryGODBDataSet.Gender' table. You can move, or remove it, as needed.
            this.genderTableAdapter2.Fill(this.carryGODBDataSet.Gender);
            // TODO: This line of code loads data into the 'carryGODBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.carryGODBDataSet.Employee);
            // TODO: This line of code loads data into the 'carryGODBDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter1.Fill(this.carryGODBDataSet.Department);


          
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HelpPage helpPage = new HelpPage();
            helpPage.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataEmployee_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            //fill the texbox and combobox with Employee table data
            IDBox.Text = dataEmployee.CurrentRow.Cells[0].Value.ToString();
            FirstNameBox.Text = dataEmployee.CurrentRow.Cells[1].Value.ToString();
            LastNameBox.Text = dataEmployee.CurrentRow.Cells[2].Value.ToString();
            GenderComboBox.SelectedValue = dataEmployee.CurrentRow.Cells[3].Value.ToString();
            
            EmailBox.Text = dataEmployee.CurrentRow.Cells[4].Value.ToString();
            PasswordBox.Text = dataEmployee.CurrentRow.Cells[5].Value.ToString();
            AddressBox.Text =  dataEmployee.CurrentRow.Cells[6].Value.ToString();
            PhoneBox.Text = dataEmployee.CurrentRow.Cells[7].Value.ToString();
            DepartmentComboBox.SelectedValue = dataEmployee.CurrentRow.Cells[8].Value.ToString();

        }

        private void buttonViewEmployee_Click(object sender, EventArgs e)
        {
            //show the Employee table on the data grid view
            employee.View(dataEmployee);
            errorLabel.Text = " ";
        }

        private void buttonSearchById_Click(object sender, EventArgs e)
        {
            panelSearchID.Visible = true;
        }

        private void buttonSearchById2_Click(object sender, EventArgs e)
        {
            //search by id 

            try
            {
                errorLabel.Text = " ";
                int id = int.Parse(dataEmployee.CurrentRow.Cells[0].Value.ToString());
               employee.SearchByID(dataEmployee,id);
               panelSearchID.Visible = false;
               errorLabel.Text = "Employee successfully found by ID!";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {

            try
            {
                errorLabel.Text = " ";
                string name = FirstNameBox.Text.Trim();
                employee.SearchByName(name, dataEmployee);
                errorLabel.Text = "Employee successfully found by Name!";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
              
            }
          
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {

            try
            {
                errorLabel.Text = " ";
                int id = int.Parse(dataEmployee.CurrentRow.Cells[0].Value.ToString());
                employee.Delete(id);
                employee.View(dataEmployee);

                errorLabel.Text = "✔️ Employee Successfully Deleted!";
                errorLabel.ForeColor = Color.LightGreen;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               
            }
        
            
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            { 
            int id = int.Parse(IDBox.Text.ToString());
            string name = FirstNameBox.Text.Trim();
            string lastname = LastNameBox.Text.Trim();
            object gender = GenderComboBox.SelectedValue;
            string email = EmailBox.Text.Trim();
            int password = int.Parse(PasswordBox.Text.Trim().ToString());
            string address = AddressBox.Text.Trim();
            long phone = long.Parse(PhoneBox.Text.Trim().ToString());
            object departmentID = DepartmentComboBox.SelectedValue;


            if (!ValidateEmail(email))
            {
                errorLabel.Text = "Please enter correct e-mail!";
                EmailBox.Focus();
                errorLabel.ForeColor = Color.Red;
                return;
            }

            employee.Update(id,name, lastname, gender, email, password, address, phone, departmentID);
            errorLabel.Text = "✔️ Employee successfully updated";
            errorLabel.ForeColor = Color.Green;
        }
            catch (Exception ex)
            {

                //errorLabel.Text = "An error occured while adding a new employee";
                MessageBox.Show(ex.Message);
                
            }
    
           // employee.View(dataEmployee);
        }

        private void DepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
