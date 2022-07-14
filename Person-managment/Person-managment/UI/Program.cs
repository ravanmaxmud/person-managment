using Person_managment.DataBase.Models;
using Person_managment.DataBase.PersonRepository;
using System;
using System.Collections.Generic;

namespace Person_managment.UI
{
    internal class Program
    {
        public static List<Person> persons = new List<Person>();
        static void Main(string[] args)
        {
            Console.WriteLine("Our available commands :");
            Console.WriteLine("/add-new-person");
            Console.WriteLine("/remove-person");
            Console.WriteLine("/update-person");
            Console.WriteLine("/add-new-adress");
            Console.WriteLine("/update-adress");
            Console.WriteLine("/remove-adress");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter Command");
                string command = Console.ReadLine();
                if (command == "/add-new-person")
                {
                    Console.Write("Please add person's name :");
                    string name = Console.ReadLine();

                    Console.Write("Please add person's surname :");
                    string lastName = Console.ReadLine();

                    Console.Write("Please add person's FatherName code :");
                    string fatherName = Console.ReadLine();

                    Console.Write("Please Enter person's Email :");
                    string email = Console.ReadLine();

                    Console.Write("Please Enter person's FIN :");
                    string fin = Console.ReadLine();

                    Person person = PersonRepisotory.AddPerson(name, lastName, fatherName, email, fin);

                    Console.WriteLine(person.GetInfo() + " - Added to system.");
                }
                else if (command == "/remove-person")
                {
                    Console.Write("Please Enter Person FIN code :");
                    string fin = Console.ReadLine();
                    PersonRepisotory.RemovePerson(fin);
                }
                else if (command == "/update-person")
                {

                }
                else if (command == "/add-new-adress")
                { 
                
                }
            }
        }
    }
}
