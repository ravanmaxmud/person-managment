using Person_managment.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_managment.DataBase.PersonRepository
{
    class PersonRepisotory
    {
        public static List<Person> persons = new List<Person>();

        public static Person Add(string name,
            string lastName,
            string fatherName,
            string email,
            string fin)

        {
            Person person = new Person(name, lastName, fatherName, email, fin);
            persons.Add(person);
            return person;
        }
        
        
    }
}
