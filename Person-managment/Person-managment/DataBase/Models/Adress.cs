using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_managment.DataBase.Models
{
    class Adress
    {
       public string Name { get; set; }
        public int Id { get; set; }

        public static int _adressIdCounter = 1;
        public Adress(string adressName)
        {
            Name = adressName;
            Id = _adressIdCounter;
            _adressIdCounter++;   
        }


    }
}
