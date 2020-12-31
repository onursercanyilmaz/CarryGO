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

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\onursercanyilmaz\Documents\GitHub\CarryGO\CarryGO\CarryGO\CarryGODB.mdf;Integrated Security=True;Connect Timeout=30");
        int password;
        object departmentID;

        public int Password { get => password; set => password = value; }
        public object DepartmentID { get => departmentID; set => departmentID = value; }

        public Customer()
        {

        }

        public override void Add(string FirstName, string LastName, object Gender, string Email, int Password , string Address, long Phone, object DepartmentID = null) 
        {
            try
            {
                string query = "INSERT INTO Customer(CustomerName,CustomerLastName,CustomerGender,CustomerEmail,CustomerAddress,CustomerPhone) VALUES (@CustomerName,@CustomerLastName,@CustomerGender,@CustomerEmail,@CustomerAddress,@CustomerPhone)";
                databaseHelper.ExecuteQuery(query);
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@CustomerName", FirstName);
                cmd.Parameters.AddWithValue("@CustomerLastName", LastName);
                cmd.Parameters.AddWithValue("@CustomerGender", Gender);
                cmd.Parameters.AddWithValue("@CustomerEmail", Email);
                cmd.Parameters.AddWithValue("@CustomerAddress", Address);
                cmd.Parameters.AddWithValue("@CustomerPhone", Phone);
                
                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Adding Customer Error: " + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }


        }

        public override void Delete(int ID ) 
        {

            try
            {
                string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
              
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("CustomerID", ID);

                databaseHelper.ExecuteNonQuery(query, parameters);
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
       
        public override void Update(int ID, string FirstName, string LastName, object Gender, string Email, int Password, string Address, long Phone, object DepartmentID = null) 
        {
            try
            {

                string query = "UPDATE Customer SET CustomerName=@CustomerName,CustomerLastName=@CustomerLastName,CustomerGender=@CustomerGender,CustomerEmail=@CustomerEmail,CustomerAddress=@CustomerAddress,CustomerPhone=@CustomerPhone WHERE CustomerID=@CustomerID";

                SqlCommand cmd = new SqlCommand(query, sqlcon);
                cmd.Parameters.AddWithValue("@CustomerID", ID);
                cmd.Parameters.AddWithValue("@CustomerName", FirstName);
                cmd.Parameters.AddWithValue("@CustomerLastName", LastName);
                cmd.Parameters.AddWithValue("@CustomerGender", Gender);
                cmd.Parameters.AddWithValue("@CustomerEmail", Email);
            
                cmd.Parameters.AddWithValue("@CustomerAddress", Address);
                cmd.Parameters.AddWithValue("@CustomerPhone", Phone);
              
                sqlcon.Open();
                cmd.ExecuteNonQuery();

                sqlcon.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Updating Customer Error: " + ex.Message);

            }
        }

        public override void View(DataGridView dgv)
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer", sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            dgv.DataSource = dtb;
            sqlcon.Close();

        }

       // public override void SearchByID(DataGridView dgv, int ID) {  }
        public override void SearchByName(string FirstName, DataGridView dgv) 
        {
            try
            {

                sqlcon.Open();
                string query = "SELECT * FROM Customer WHERE CustomerName LIKE '" + FirstName + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dgv.DataSource = dtbl;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Finding Customer Error: " + ex.Message);

            }
            finally
            {
                sqlcon.Close();
            }
        }

        public override void Login(int ID, int Password)
        {

        }
        public override void Logout() { }

    }
}
