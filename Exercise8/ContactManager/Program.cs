using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace ContactManager
{
    class Program
    {
        private static uint _size;
        private static uint _current = 0;
        private static Contact[] _contacts;

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("--- CONTACT MANAGER ---");
            Console.WriteLine("[1] Add contact");
            Console.WriteLine("[2] Display all contacts");
            Console.WriteLine("[3] Exit");
        }

        private static Gender GetGender()
        {
            char input = ReadValues.GetCharacter("Type 'M' for Male, 'F' for female ");
            while(true)
            {
                switch(input)
                {
                    case 'M':
                        return Gender.MALE;
                    case 'm':
                        return Gender.MALE;
                    case 'F':
                        return Gender.FEMALE;
                    case 'f':
                        return Gender.FEMALE;
                    default:
                        Console.WriteLine($"Wrong input ({input}) try again!");
                        input = ReadValues.GetCharacter("Type 'M' for Male, 'F' for female.");
                        break;
                }
            }
        }

        private static Address GetAddress()
        {
            Address address = new Address();

            address.City = ReadValues.GetString("Provide City: ");
            address.Street = ReadValues.GetString("Provide street: ");
            address.HouseNo = ReadValues.GetInt("Provide house number: ");
            return address;
        }

        private static Contact GetContact()
        {
            Contact contact = new Contact();

            contact.FirstName = ReadValues.GetString("Provide first name: ");
            contact.LastName = ReadValues.GetString("Provide last name: ");
            contact.PhoneNo = ReadValues.GetInt("Provide phone number: ");
            contact.Gender = GetGender();
            contact.Address = GetAddress();

            return contact;
        }

        private static void AddNewContact()
        {
            if(_size == _current)
            {
                Console.WriteLine("The contact array is full!");
            } else
            {
                _contacts[_current] = GetContact();
                _current++;
                Console.WriteLine("Contact added!");
            }
        }

        private static void DisplayContacts()
        {
            Console.WriteLine("--- Displaying all contacts ---");
            foreach(Contact c in _contacts)
                Console.WriteLine(c);
            Console.WriteLine();
        }


        private static void MainLoop()
        {
            bool exit = false;
            int input;
            _size = ReadValues.GetUint("Provide number of contacts: ");
            _contacts = new Contact[_size];
            while(!exit)
            {
                DisplayMenu();
                input = ReadValues.GetInt("Select option 1-3: ");
                switch (input)
                {
                    case 1:
                        AddNewContact();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        DisplayContacts();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Exiting ...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine($"Wrong input ({input}). Try again.");
                        break;
                }
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
