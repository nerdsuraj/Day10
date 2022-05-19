using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ADDRESS BOOK SYSTEM !");
            Contact obj = new Contact();
            CreateContact cont = new CreateContact();
            Console.WriteLine("Enter \n0 for CREATE CONTACT IN ADDRESSBOOK PROGRAM \n2 for USER INPUT CONTACT IN ADDRESSBOOK PROGRAM \n3 for EDIT CONTACTS IN ADDRESSBOOK PROGRAM\n4 for DELETING CONTACT PROGRAM\n5 for MULTIPLE PERSON ADDRESS BOOK \n6 for MULTIPLE ADDRESS BOOK DICTIONARY PROGRAM \n");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 0:
                    cont.createContactMethod();
                    cont.printContact();
                    break;

                case 2:
                    AddContactUserInput obj2 = new AddContactUserInput();
                    obj2.addContact();
                    obj2.printAddedContact();
                    break;

                case 3:
                    EditContacts obj3 = new EditContacts();
                    obj3.editContacts();
                    break;

                case 4:
                    DeleteContactAddressBook obj4 = new DeleteContactAddressBook();
                    obj4.deleteContact();
                    break;

                case 5:
                    MultiplePersonAddressBook obj5 = new MultiplePersonAddressBook();
                    obj5.addMultipleContact();
                    obj5.printContact();
                    obj5.editMultiContact();
                    obj5.deleteMultiContact();
                    Console.WriteLine("After removing Contacts");
                    obj5.printContact();
                    break;

                case 6:
                    MultipleAddressBookDictionary obj6 = new MultipleAddressBookDictionary();
                    obj6.dictionaryContacts();
                    break;
            }
            Console.ReadKey();
        }
    }
}
