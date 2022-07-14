using Person_managment.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_managment.DataBase.PersonRepository
{
    
    internal class AdressRepository
    {
        public static List<Adress> adresses = new List<Adress>();
        public static Adress AddAdress(string adressName)
        {
            Adress adress = new Adress(adressName);
            adresses.Add(adress);
            return adress;
        }
   
    }
}
