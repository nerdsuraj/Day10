using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class MultiplePersonAddressBook
    {
        AddContactUserInput ObjAdd = new AddContactUserInput();
        public void addMultipleContact()
        {
            Console.WriteLine("Enter the Number of Contact, you want to add");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                ObjAdd.addContact();
            }
        }

        public void printContact()
        {
            ObjAdd.printAddedContact();
        }

        public void editMultiContact()
        {
            Console.WriteLine("\nEnter the FirstName of the Contact person whose contact you want to Edit\n");
            String Name = Console.ReadLine().ToLower();
            foreach (var info in ObjAdd.ContactBook)
            {
                if (info.FirstName == Name)
                {
                    Console.WriteLine("Enter the given number for EDITING \n1 for FIRSTNAME \n2 for LASTNAME \n3 for CITY \n4 for STATE \n5 for ZIPCODE \n6 for PHONENUMBER \n7 for E_MAIL\n");
                    int opt = Convert.ToInt32(Console.ReadLine());

                    switch (opt)
                    {

                        case 1:
                            Console.WriteLine("Enter the FIRST NAME ");
                            info.FirstName = Console.ReadLine();
                            Console.WriteLine(info.FirstName);
                            break;

                        case 2:
                            Console.WriteLine("Enter the LAST NAME ");
                            info.LastName = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("Enter the CITY ");
                            info.City = Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("Enter the STATE ");
                            info.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the ZIPCODE ");
                            info.ZipCode = Console.ReadLine();
                            break;

                        case 6:
                            Console.WriteLine("Enter the PHONENUMBER ");
                            info.PhoneNumber = Console.ReadLine();
                            break;

                        case 7:
                            Console.WriteLine("Enter the E_MAIL ");
                            info.E_Mail = Console.ReadLine();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Name doesn't Match, NO PERSON WITH THIS CONTACT");
                }
            }
            ObjAdd.printAddedContact();
        }

        public void deleteMultiContact()
        {
            Console.WriteLine("Enter the FIRSTNAME of person you would like to remove");
            String firstName = Console.ReadLine().ToLower();
            foreach (var info in ObjAdd.ContactBook)
            {
                if (info.FirstName == firstName)
                {
                    ObjAdd.ContactBook.Remove(info);
                    Console.WriteLine("Contact removed Successfully");
                    break;
                }

            }
        }
    }
}
