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

        public override void Add(string FirstName, string LastName, object Gender, string Email, int Password, string Address, long Phone, object DepartmentID) { }

        public override void Delete(int ID ) { }
        public override void Update(int ID, string FirstName, string LastName, object Gender, string Email, int Password, string Address, long Phone, object DepartmentID) { }
        public override void SearchByID(DataGridView dgv, int ID) {  }
        public override void SearchByName(string FirstName, DataGridView dgv) { }

        public override void Login(int ID, int Password)
        {

        }
        public override void Logout() { }

    }
}
