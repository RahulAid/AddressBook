using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Repository
{
    internal class ContactDetailsRepository
    {
        Dictionary<string, ContactDetails> contactDetails = new Dictionary<string, ContactDetails>();

        public void AddContactDetails(ContactDetails contactDetail) 
        {
            contactDetails.Add(contactDetail.UniqueName, contactDetail);
        }

        public void EditContactDetails(string uniqueName)
        {
            var obj = contactDetails[uniqueName];
            contactDetails.Remove(uniqueName);
            Console.WriteLine("\nChoose what is to be edited from the list below : \n1.First Name \n2.Last Name \n3.Mobile Number \n4.EMail Id \n5.Address \n6.City Name \n7.State Name \n8.Zip Code \n");
            int newValue = Convert.ToInt32(Console.ReadLine());
            switch (newValue)
            {
                case 1:
                    Console.WriteLine("\nEnter New First Name : ");
                    string? firstName = Console.ReadLine();
                    obj.FirstName = firstName;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 2:
                    Console.WriteLine("\nEnter New Last Name : ");
                    string? lastName = Console.ReadLine();
                    obj.LastName = lastName;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 3:
                    Console.WriteLine("\nEnter New Mobile Number : ");
                    long mobileNumber = Convert.ToInt64(Console.ReadLine());
                    obj.MobileNumber = mobileNumber;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 4:
                    Console.WriteLine("\nEnter New EMail Id : ");
                    string? email = Console.ReadLine();
                    obj.EMail = email;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 5:
                    Console.WriteLine("\nEnter New Address : ");
                    string? address = Console.ReadLine();
                    obj.Address = address;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 6:
                    Console.WriteLine("\nEnter New City Name : ");
                    string? city = Console.ReadLine();
                    obj.City = city;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 7:
                    Console.WriteLine("\nEnter New State Name : ");
                    string? state = Console.ReadLine();
                    obj.State = state;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
                case 8:
                    Console.WriteLine("\nEnter New Zip Code : ");
                    int zip = Convert.ToInt32(Console.ReadLine());
                    obj.Zip = zip;
                    contactDetails.Add(obj.UniqueName, obj);
                    break;
            }
        }

        public void DeleteContact(string uniqueName)
        {
            var obj = contactDetails[uniqueName];
            contactDetails.Remove(uniqueName);
        }

        public void DisplayContact()
        {
            foreach (var data in contactDetails)
            {
                Console.WriteLine($"\nUnique Name   : {data.Value.UniqueName}");
                Console.WriteLine($"First Name      : {data.Value.FirstName}");
                Console.WriteLine($"Last Name       : {data.Value.LastName}");
                Console.WriteLine($"Mobile Number   : {data.Value.MobileNumber}");
                Console.WriteLine($"EMail Id        : {data.Value.EMail}");
                Console.WriteLine($"Address         : {data.Value.Address}");
                Console.WriteLine($"City Name       : {data.Value.City}");
                Console.WriteLine($"State Name      : {data.Value.State}");
                Console.WriteLine($"Zip Code        : {data.Value.Zip}");
            }
        }
    }
}