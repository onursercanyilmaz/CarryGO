using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CarryGO.Classes
{
    class Customer : Person
    {
        public Customer()
        {

        }

        public override void Add(TextBox one, TextBox two, TextBox three, TextBox four, TextBox five, TextBox six, ComboBox cone, ComboBox ctwo, Label error) { }

        public override void Delete(DataGridView dgv, Label error, TextBox IDBox) { }
        public override void Update(TextBox one, TextBox two, TextBox three, TextBox four, TextBox five, TextBox six, ComboBox cone, ComboBox ctwo, Label error, TextBox IDBox) { }
        public override void SearchByID(TextBox id, DataGridView dgv) { }
        public override void SearchByName(TextBox name, DataGridView dgv) { }

        public override void Login(TextBox id, TextBox password, Label error, Form form)
        {

            try
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\onursercanyilmaz\Documents\GitHub\CarryGO\CarryGO\CarryGO\CarryGODB.mdf;Integrated Security=True;Connect Timeout=30");
                sqlcon.Open();
                string query = "SELECT * FROM Employee WHERE FirstName ='" + id.Text.Trim() + "' AND EmployeePassword='" + password.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {

                    MainPage main = new MainPage();
                    main.Show();
                    sqlcon.Close();
                }
            }
            catch (Exception)
            {


               error.Text = "WRONG Employee ID/PASSWORD!";
            }
        }
        public override void Logout() { }

    }
}
