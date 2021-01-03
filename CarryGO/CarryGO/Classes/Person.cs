using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarryGO.Classes;
using CarryGO.Properties;
using System.Data;
using System.Windows.Forms;

namespace CarryGO.Classes
{
    public  abstract class Person //Main Class for Employee and Customer
    {
        int id;
        string firstName;
        string lastName;
        string gender;
        string email;
        string address;
        long phone;

        public Person()
        {

        }

        //From C# Docs : Get and Set
        public int ID { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public long Phone { get => phone; set => phone = value; }

        public virtual void View(DataGridView dgv) { }
        public virtual void Add(string FirstName, string LastName, object Gender, string Email, int Password, string Address, long Phone, object DepartmentID) { }
        public virtual void Save() { }
        public virtual void Delete(int ID) { }
        public virtual void Update(int ID, string FirstName, string LastName, object Gender, string Email, int Password, string Address, long Phone, object DepartmentID) { }
        public virtual void SearchByID(DataGridView dgv, int ID) { }
        public virtual void SearchByName(string FirstName, DataGridView dgv) { }
        public abstract Person Login(int ID, int Password);
        
        public virtual void Logout() { }



    }
}
