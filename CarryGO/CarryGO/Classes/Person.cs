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
    class Person //Main Class for Employee and Customer
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

/*
        public void Add() { }
        public void Save() { }
        public void Delete() { }
        public void Update() { }
        public void Search() { }

*/
    }
}
