using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class MultipleAddressBookDictionary
    {
        Dictionary<string, List<Contact>> MultiDict = new Dictionary<string, List<Contact>>();
        public void dictionaryContacts()
        {
            AddContactUserInput ObjAdd = new AddContactUserInput();
            Console.WriteLine("How many ADDRESSBOOK, You want to create ");
            int BookNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= BookNum; i++)
            {
                Console.WriteLine("How many contcts you want to add in addressbook ");
                int ContactNum = Convert.ToInt32(Console.ReadLine());
                for (int j = 1; j <= ContactNum; j++)
                {
                    ObjAdd.addContact();
                }
                Console.WriteLine("What name you want to give to address book");
                string Bookname = Console.ReadLine();
                MultiDict.Add(Bookname, ObjAdd.ContactBook);
            }
            Console.WriteLine("AddressBook added successfully");
        }

    }
}
