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

        

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            //Add new employe to Employee table
            employee.Add(FirstNameBox, LastNameBox, EmailBox, PasswordBox, AddressBox, PhoneBox, GenderComboBox, DepartmentComboBox, errorLabel);
        }

        private void AddEmployeePage_Load(object sender, EventArgs e)
        {

            this.genderTableAdapter.Fill(this.carryGODBDataSet.Gender);
            this.departmentTableAdapter.Fill(this.carryGODBDataSet.Department);
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
        }

        private void buttonSearchById_Click(object sender, EventArgs e)
        {
            panelSearchID.Visible = true;
        }

        private void buttonSearchById2_Click(object sender, EventArgs e)
        {
            //search by id 
            employee.SearchByID(IDBox, dataEmployee);
            panelSearchID.Visible = false;
        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {
            employee.SearchByName(FirstNameBox, dataEmployee);
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            
            employee.Delete(dataEmployee, errorLabel, IDBox);
            employee.View(dataEmployee);
            
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            employee.Update(FirstNameBox, LastNameBox, EmailBox, PasswordBox, AddressBox, PhoneBox, GenderComboBox, DepartmentComboBox, errorLabel,IDBox);
           // employee.View(dataEmployee);
        }
    }
}
