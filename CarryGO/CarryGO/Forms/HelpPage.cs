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

namespace CarryGO
{
    public partial class HelpPage : Form
    {
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
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\onursercanyilmaz\Documents\GitHub\CarryGO\CarryGO\CarryGO\CarryGODB.mdf;Integrated Security=True;Connect Timeout=30");
                sqlcon.Open();
                string query = "SELECT * FROM Employee WHERE FirstName ='" + IDBox.Text.Trim() + "' AND EmployeePassword='" + PasswordBox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    this.Hide();
                    AddEmployeePage addEmployeePage = new AddEmployeePage();
                    addEmployeePage.Show();
                    sqlcon.Close();
                }
                else if (IDBox.Text =="" && PasswordBox.Text=="")
                {
                    labelError.Text = "WRONG ADMIN ID/PASSWORD!";
                }
            }
            catch (Exception)
            {

                labelError.Text = "WRONG ADMIN ID/PASSWORD!";
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
    }
}
