using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_managment.DataBase.Models
{
     class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string FIN { get; set; }
        public int Id { get; set; }
        public static int _idCounter = 1;
    

        public Person(string firstName ,string lastName, string fatherName,string eMail ,string fin)
        {
            FirstName = firstName;
            LastName = lastName;
            FatherName = fatherName;
            Email = eMail;
            FIN = fin;
            Id = _idCounter;
            _idCounter++;
        }

    }
}
