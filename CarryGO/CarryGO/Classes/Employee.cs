using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarryGO.Classes;
using CarryGO.Properties;
using System.Data;


namespace CarryGO.Classes
{
    class Employee : Person
    {
        int password;
        int departmentID;

        public Employee()
        {

        }

        public int Password { get => password; set => password = value; }
        public int DepartmentID { get => departmentID; set => departmentID = value; }


        public void ViewEmployee() { }
        public void AddEmployee() { }
        public void DeleteEmployee() { }
        public void UpdateEmployee() { }
        public void SearchEmployeeID() { }
        public void SearchEmployeeName() { }
        public void Login() { }
        public void Logout() { }

    }
}
