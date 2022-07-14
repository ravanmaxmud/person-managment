using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_managment.DataBase.Models
{
    class Adress
    {
       public string AdressName { get; set; }
        public int AdressId { get; set; }

        public static int _adressIdCounter = 1;
        public Adress(string adressName)
        {
            AdressName = adressName;
            AdressId = _adressIdCounter;
            _adressIdCounter++;   
        }


    }
}
