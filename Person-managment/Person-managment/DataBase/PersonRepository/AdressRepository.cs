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
        public static void RemoveAdress(int id)
        {
            for (int i = 0; i < adresses.Count; i++)
            {
                if (adresses[i].Id == id)
                {
                    Console.WriteLine(adresses[i].GetInfo());
                    adresses.RemoveAt(i);
                }
            }
        }
        public static Adress UpdateAdress(int id, string name)
        {
            Adress adress = null;

            for (int i = 0; i < adresses.Count; i++)
            {
                if (adresses[i].Id == id)
                {
                    adresses[i].Name = name;
                    adress = adresses[i];
                }
            }

            return adress;
        }

    }
}
