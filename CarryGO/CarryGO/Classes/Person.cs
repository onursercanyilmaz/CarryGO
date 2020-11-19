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
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public long Phone { get => phone; set => phone = value; }

        public virtual void View(DataGridView dgv) { }
        public virtual void Add(TextBox one, TextBox two, TextBox three, TextBox four, TextBox five, TextBox six, ComboBox cone, ComboBox ctwo, Label error) { }
        public virtual void Save() { }
        public virtual void Delete(DataGridView dgv, Label error, TextBox IDBox) { }
        public virtual void Update(TextBox one, TextBox two, TextBox three, TextBox four, TextBox five, TextBox six, ComboBox cone, ComboBox ctwo, Label error, TextBox IDBox) { }
        public virtual void SearchByID(TextBox id, DataGridView dgv) { }
        public virtual void SearchByName(TextBox name, DataGridView dgv) { }
        public virtual void Login(TextBox id, TextBox password, Label error, Form form) { }
        public virtual void Logout() { }



    }
}
