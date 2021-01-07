using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarryGO.Classes;
using CarryGO.Forms;

namespace CarryGO
{
    public partial class HelpPage : Form
    {
        Employee employee = new Employee();
        public HelpPage()
        {
            InitializeComponent();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginPage = new Login();
            loginPage.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(IDBox.Text.Trim().ToString());
                int password = int.Parse(PasswordBox.Text.Trim().ToString());

                var emp = employee.Login(id, password);
                if (emp != null)
                {
                    AddEmployeePage main = new AddEmployeePage();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    labelError.Text = "ID or Password is incorrect.";
                    labelError.ForeColor = Color.Coral;
                }




            }
            catch (Exception)
            {

                labelError.Text = "Please check you ID or Password!";
            }



        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            formSettings form = new formSettings();
            form.ShowDialog();
        }
    }
}
