using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarryGO.Classes;
using CarryGO.Properties;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;



namespace CarryGO.Classes
{
    
    class Employee : Person
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\onursercanyilmaz\Documents\GitHub\CarryGO\CarryGO\CarryGO\CarryGODB.mdf;Integrated Security=True;Connect Timeout=30");
        int password;
        int departmentID;
       


        public int Password { get => password; set => password = value; }
        public int DepartmentID { get => departmentID; set => departmentID = value; }


        public override void View(DataGridView dgv) 
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee",sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            
            dgv.DataSource = dtb;
            sqlcon.Close();

        }
        public override void Add(TextBox one, TextBox two, TextBox three, TextBox four, TextBox five, TextBox six, ComboBox cone, ComboBox ctwo, Label error) 
        {
            try
            {
                string query = "INSERT INTO Employee(FirstName,LastName,EmployeeGender,EmployeeEmail,EmployeePassword,EmployeeAddress,EmployeePhone, DepartmentID) VALUES (@FirstName,@LastName,@EmployeeGender,@EmployeeEmail,@EmployeePassword,@EmployeeAddress,@EmployeePhone, @DepartmentID)";
                
                SqlCommand cmd = new SqlCommand(query,sqlcon);
                cmd.Parameters.AddWithValue("@FirstName",one.Text.Trim().ToString());
                cmd.Parameters.AddWithValue("@LastName",two.Text.Trim().ToString());
                cmd.Parameters.AddWithValue("@EmployeeGender",cone.SelectedValue);
                cmd.Parameters.AddWithValue("@EmployeeEmail",three.Text.Trim().ToString());
                cmd.Parameters.AddWithValue("@EmployeePassword",Int32.Parse(four.Text.Trim().ToString()));
                cmd.Parameters.AddWithValue("@EmployeeAddress",five.Text.Trim().ToString());
                cmd.Parameters.AddWithValue("@EmployeePhone",Int32.Parse(six.Text.Trim().ToString()));
                cmd.Parameters.AddWithValue("@DepartmentID",ctwo.SelectedValue);
                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();
                error.Text = "Employee successfully added";
                
                
            }
            catch (Exception )
            {
                error.Text = "An error occured while adding a new employee";
            }
           

        }
        public override void Delete(DataGridView dgv, Label error,TextBox IDBox) 
        {
            try
            {
                string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@EmployeeID", Int32.Parse(IDBox.Text.Trim().ToString()));
                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();




                error.Text = "Employee successfully deleted";
            }
            catch (Exception)
            {

                error.Text = "An error occured while employee deleting";
            }
            
            
        }
        public override void Update(TextBox one, TextBox two, TextBox three, TextBox four, TextBox five, TextBox six, ComboBox cone, ComboBox ctwo, Label error, TextBox IDBox) 
        {
            try
            {
                string query = "UPDATE Employee SET FirstName=@FirstName,LastName=@LastName,EmployeeGender=@EmployeeGender,EmployeeEmail=@EmployeeEmail,EmployeePassword=@EmployeePassword,EmployeeAddress=@EmployeeAddress,EmployeePhone=@EmployeePhone, DepartmentID=@DepartmentID WHERE EmployeeID=@EmployeeID";

                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@EmployeeID", Int32.Parse(IDBox.Text.Trim().ToString()));
                cmd.Parameters.AddWithValue("@FirstName", one.Text.Trim().ToString());
                cmd.Parameters.AddWithValue("@LastName", two.Text.Trim().ToString());
                cmd.Parameters.AddWithValue("@EmployeeGender", cone.SelectedValue);
                cmd.Parameters.AddWithValue("@EmployeeEmail", three.Text.Trim().ToString());
                cmd.Parameters.AddWithValue("@EmployeePassword", Int32.Parse(four.Text.Trim().ToString()));
                cmd.Parameters.AddWithValue("@EmployeeAddress", five.Text.Trim().ToString());
                cmd.Parameters.AddWithValue("@EmployeePhone", Int32.Parse(six.Text.Trim().ToString()));
                cmd.Parameters.AddWithValue("@DepartmentID", ctwo.SelectedValue);
                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();
                error.Text = "Employee successfully updated";


            }
            catch (Exception)
            {
                error.Text = "An error occured while updating the employee";
            }


        }
        public override void SearchByID(TextBox id, DataGridView dgv) 
        {
            int idno = Int32.Parse(id.Text);
            try
            {

                sqlcon.Open();
                string query = "SELECT * FROM Employee WHERE EmployeeID ='" + idno + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dgv.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception)
            {

                throw;
            }
            


        }
        public override void SearchByName(TextBox name, DataGridView dgv)
        {
            try
            {

                sqlcon.Open();
                string query = "SELECT * FROM Employee WHERE FirstName ='" + name.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dgv.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
       
        public override void Login(TextBox id, TextBox password, Label error, Form form) 
        {
           
            try
            {
                
                sqlcon.Open();
                string query = "SELECT * FROM Employee WHERE EmployeeID ='" + id.Text.Trim() + "' AND EmployeePassword='" + password.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    error.Text = "";
                    MainPage main = new MainPage();
                    main.Show();
                    sqlcon.Close();
                    form.Hide();
                }
    
            }
            catch (Exception)
            {
                error.Text = "WRONG Employee ID/PASSWORD!";
            }
        }
        public override void Logout() 
        {
            Login login = new Login();
            login.Show();
        
        }

    }
}
