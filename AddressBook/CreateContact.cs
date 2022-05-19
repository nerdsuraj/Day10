using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateContact
    {

        public List<Contact> ContactBook = new List<Contact>();
        public void createContactMethod()
        {
            Contact obj1 = new Contact();
            obj1.FirstName = "Suraj";
            obj1.LastName = "Kumar";
            obj1.City = "Dhanbad";
            obj1.State = "Jharkhand";
            obj1.ZipCode = "828104";
            obj1.PhoneNumber = "6200749278";
            obj1.E_Mail = "Soorajkrpandit@gmail.com";
            ContactBook.Add(obj1);
            Console.WriteLine("\nADDRESS BOOK Is Created ");
        }

        //Printing ContactBook
        public void printContact()
        {
            Console.WriteLine("\nPrinting Contact information ..................................\n");
            foreach (var obje in ContactBook)
            {
                Console.WriteLine("FirstName is " + obje.FirstName);
                Console.WriteLine("LastName is " + obje.LastName);
                Console.WriteLine("City is " + obje.City);
                Console.WriteLine("State is " + obje.State);
                Console.WriteLine("ZipCode is " + obje.ZipCode);
                Console.WriteLine("PhoneNumber is " + obje.PhoneNumber);
                Console.WriteLine("E_Mail is " + obje.E_Mail);
            }
        }
    }
}
