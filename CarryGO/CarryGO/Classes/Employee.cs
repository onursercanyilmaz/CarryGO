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

        
        int password;
        object departmentID;
       


        public int Password { get => password; set => password = value; }
        public object DepartmentID { get => departmentID; set => departmentID = value; }


        public override void View(DataGridView dgv) 
        {

            try
            {
                string query = "SELECT * FROM Employee";
                databaseHelper.ExecuteQuerys(query, dgv);

            }
            catch (Exception)
            {

                throw;
            }
           

        }

        
        
        public override void Add(string FirstName, string LastName, object Gender, string Email, int Password, string Address, long Phone, object DepartmentID) 
        {
            try
            {
                string query = "INSERT INTO Employee(FirstName,LastName,EmployeeGender,EmployeeEmail,EmployeePassword,EmployeeAddress,EmployeePhone, DepartmentID) VALUES (@FirstName,@LastName,@EmployeeGender,@EmployeeEmail,@EmployeePassword,@EmployeeAddress,@EmployeePhone, @DepartmentID)";

                SqlParameter[] parameters = new SqlParameter[8];

              
                parameters[0] = new SqlParameter("FirstName", FirstName);
                parameters[1] = new SqlParameter("LastName", LastName);
                parameters[2] = new SqlParameter("EmployeeGender", Gender);
                parameters[3] = new SqlParameter("EmployeeEmail", Email);
                parameters[4] = new SqlParameter("EmployeePassword", Password);
                parameters[5] = new SqlParameter("EmployeeAddress", Address);
                parameters[6] = new SqlParameter("EmployeePhone", Phone);
                parameters[7] = new SqlParameter("DepartmentID", DepartmentID);


                databaseHelper.ExecuteNonQuery(query, parameters);





                //SqlCommand cmd = new SqlCommand(query,sqlcon);
                //cmd.Parameters.AddWithValue("@FirstName", FirstName);
                //cmd.Parameters.AddWithValue("@LastName",LastName);
                //cmd.Parameters.AddWithValue("@EmployeeGender",Gender);
                //cmd.Parameters.AddWithValue("@EmployeeEmail",Email);
                //cmd.Parameters.AddWithValue("@EmployeePassword",Password);
                //cmd.Parameters.AddWithValue("@EmployeeAddress",Address);
                //cmd.Parameters.AddWithValue("@EmployeePhone",Phone);
                //cmd.Parameters.AddWithValue("@DepartmentID",DepartmentID);
                //sqlcon.Open();
                //cmd.ExecuteNonQuery();

                //sqlcon.Close();
               
                
                
            }
            catch (Exception ex)
            {
                throw new Exception("Adding Employee Error: " + ex.Message);
            }
            


        }
        public override void Delete(int ID) 
        {
            try
            {
                string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
                //SqlCommand cmd = new SqlCommand(query, sqlcon);
                //cmd.Parameters.AddWithValue("@EmployeeID", ID);
                //sqlcon.Open();
                //cmd.ExecuteNonQuery();

                //sqlcon.Close();

                
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("EmployeeID", ID);

                databaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {

                throw new Exception("Deleting Employee Error: " + ex.Message);
            }
            
            
            
        }
        public override void Update(int ID, string FirstName, string LastName, object Gender, string Email, int Password, string Address, long Phone, object DepartmentID) 
        {
            try
            {
               
                string query = "UPDATE Employee SET FirstName=@FirstName,LastName=@LastName,EmployeeGender=@EmployeeGender,EmployeeEmail=@EmployeeEmail,EmployeePassword=@EmployeePassword,EmployeeAddress=@EmployeeAddress,EmployeePhone=@EmployeePhone, DepartmentID=@DepartmentID WHERE EmployeeID=@EmployeeID";

                SqlParameter[] parameters = new SqlParameter[9];

                parameters[0] = new SqlParameter("EmployeeID", ID);
                parameters[1] = new SqlParameter("FirstName", FirstName);
                parameters[2] = new SqlParameter("LastName", LastName);
                parameters[3] = new SqlParameter("EmployeeGender", Gender);
                parameters[4] = new SqlParameter("EmployeeEmail", Email);
                parameters[5] = new SqlParameter("EmployeePassword", Password);
                parameters[6] = new SqlParameter("EmployeeAddress", Address);
                parameters[7] = new SqlParameter("EmployeePhone", Phone);
                parameters[8] = new SqlParameter("DepartmentID", DepartmentID);


                databaseHelper.ExecuteNonQuery(query, parameters);



                //SqlCommand cmd = new SqlCommand(query, sqlcon);
                //cmd.Parameters.AddWithValue("@EmployeeID", ID);
                //cmd.Parameters.AddWithValue("@FirstName", FirstName);
                //cmd.Parameters.AddWithValue("@LastName", LastName);
                //cmd.Parameters.AddWithValue("@EmployeeGender", Gender);
                //cmd.Parameters.AddWithValue("@EmployeeEmail", Email);
                //cmd.Parameters.AddWithValue("@EmployeePassword", Password);
                //cmd.Parameters.AddWithValue("@EmployeeAddress", Address);
                //cmd.Parameters.AddWithValue("@EmployeePhone", Phone);
                //cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID);
                //sqlcon.Open();
                //cmd.ExecuteNonQuery();

                //sqlcon.Close();
               


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

                string query = "SELECT * FROM Employee WHERE EmployeeID ='" + ID + "'";
                databaseHelper.ExecuteQuerys(query, dgv);



                //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                //DataTable dtbl = new DataTable();
                //sda.Fill(dtbl);
                //dgv.DataSource = dtbl;
                //sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Finding Employee Error: " + ex.Message);
            }
           



        }
        public override void SearchByName(string FirstName, DataGridView dgv)
        {
            try
            {

                string query = "SELECT * FROM Employee WHERE FirstName LIKE '" + FirstName + "%'";
                databaseHelper.ExecuteQuerys(query, dgv);

                //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                //DataTable dtbl = new DataTable();
                //sda.Fill(dtbl);
                //dgv.DataSource = dtbl;
                //sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Finding Employee Error: " + ex.Message);
                
            }
            

        }

        public override Person Login(int ID, int Password)
        {
            try
            {
                string query = "SELECT * FROM Employee WHERE EmployeeID ='" + ID + "' AND EmployeePassword='" + Password + "'";
                var dt = databaseHelper.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    Employee emp = new Employee();
                    emp.ID = int.Parse(dt.Rows[0]["EmployeeID"].ToString());
 
                    emp.Password = int.Parse(dt.Rows[0]["EmployeePassword"].ToString());

                    return emp;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Log In Error: " + ex.Message);
            }
        }
        public override void Logout() 
        {
            Login login = new Login();
            login.Show();
        
        }

    }
}
