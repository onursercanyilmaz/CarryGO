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
        object departmentID;
       


        public int Password { get => password; set => password = value; }
        public object DepartmentID { get => departmentID; set => departmentID = value; }


        public override void View(DataGridView dgv) 
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Employee",sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            
            dgv.DataSource = dtb;
            sqlcon.Close();

        }

        
        
        public override void Add(string FirstName, string LastName, object Gender, string Email, int Password, string Address, long Phone, object DepartmentID) 
        {
            try
            {
                string query = "INSERT INTO Employee(FirstName,LastName,EmployeeGender,EmployeeEmail,EmployeePassword,EmployeeAddress,EmployeePhone, DepartmentID) VALUES (@FirstName,@LastName,@EmployeeGender,@EmployeeEmail,@EmployeePassword,@EmployeeAddress,@EmployeePhone, @DepartmentID)";
                
                SqlCommand cmd = new SqlCommand(query,sqlcon);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName",LastName);
                cmd.Parameters.AddWithValue("@EmployeeGender",Gender);
                cmd.Parameters.AddWithValue("@EmployeeEmail",Email);
                cmd.Parameters.AddWithValue("@EmployeePassword",Password);
                cmd.Parameters.AddWithValue("@EmployeeAddress",Address);
                cmd.Parameters.AddWithValue("@EmployeePhone",Phone);
                cmd.Parameters.AddWithValue("@DepartmentID",DepartmentID);
                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();
               
                
                
            }
            catch (Exception ex)
            {
                throw new Exception("Adding Employee Error: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }


        }
        public override void Delete(int ID) 
        {
            try
            {
                string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@EmployeeID", ID);
                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Deleting Employee Error: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            
            
        }
        public override void Update(int ID, string FirstName, string LastName, object Gender, string Email, int Password, string Address, long Phone, object DepartmentID) 
        {
            try
            {
               
                string query = "UPDATE Employee SET FirstName=@FirstName,LastName=@LastName,EmployeeGender=@EmployeeGender,EmployeeEmail=@EmployeeEmail,EmployeePassword=@EmployeePassword,EmployeeAddress=@EmployeeAddress,EmployeePhone=@EmployeePhone, DepartmentID=@DepartmentID WHERE EmployeeID=@EmployeeID";

                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@EmployeeID", ID);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@EmployeeGender", Gender);
                cmd.Parameters.AddWithValue("@EmployeeEmail", Email);
                cmd.Parameters.AddWithValue("@EmployeePassword", Password);
                cmd.Parameters.AddWithValue("@EmployeeAddress", Address);
                cmd.Parameters.AddWithValue("@EmployeePhone", Phone);
                cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();
               


            }
            catch (Exception ex)
            {
                throw new Exception("Updating Employee Error: " + ex.Message);
               
            }


        }
       
        public override void SearchByID(DataGridView dgv, int ID) 
        {
          
            try
            {

                sqlcon.Open();
                string query = "SELECT * FROM Employee WHERE EmployeeID ='" + ID + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dgv.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Finding Employee Error: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }



        }
        public override void SearchByName(string FirstName, DataGridView dgv)
        {
            try
            {

                sqlcon.Open();
                string query = "SELECT * FROM Employee WHERE FirstName LIKE '" + FirstName + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dgv.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Finding Employee Error: " + ex.Message);
                
            }
            finally
            {
                sqlcon.Close();
            }

        }
       
        public override void  Login(int ID, int Password) 
        {
           
            try
            {
                
                sqlcon.Open();
                string query = "SELECT * FROM Employee WHERE EmployeeID ='" + ID + "' AND EmployeePassword='" + Password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
               
            }
            catch (Exception)
            {
                throw;
            }
        }
        public override void Logout() 
        {
            Login login = new Login();
            login.Show();
        
        }

    }
}
