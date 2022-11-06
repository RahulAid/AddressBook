using AddressBook.Model;
using AddressBook.Repository;
using System.Diagnostics.Metrics;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Prrogram");
            ContactDetailsRepository contactDetails = new ContactDetailsRepository();
            bool flag = true;
            while (flag)
            {
                ContactDetails contactDetail = null;
                
                Console.WriteLine("Choose the operation to be performed on Contact Details : \n1. Add Contact Details \n2. Edit Contact Details \n3. Delete Contact Details \n");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter A to Add Details");
                        string? input1 = Console.ReadLine();
                        while (input1 == "A")
                        {
                            Console.WriteLine("\nEnter First Name : ");
                            string? firstName = Console.ReadLine();

                            Console.WriteLine("\nEnter Last Name : ");
                            string? lastName = Console.ReadLine();

                            Console.WriteLine("\nEnter Mobile Number : ");
                            long mobileNumber = Convert.ToInt64(Console.ReadLine());

                            Console.WriteLine("\nEnter EMail Id : ");
                            string? eMail = Console.ReadLine();

                            Console.WriteLine("\nEnter Address : ");
                            string? address = Console.ReadLine();

                            Console.WriteLine("\nEnter City Name : ");
                            string? city = Console.ReadLine();

                            Console.WriteLine("\nEnter State Name : ");
                            string? state = Console.ReadLine();

                            Console.WriteLine("\nEnter Zip Code: ");
                            int zip = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nEnter any key to exit.");
                            string? input = Console.ReadLine();

                            contactDetail = new ContactDetails()
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                MobileNumber = mobileNumber,
                                EMail = eMail,
                                Address = address,
                                City = city,
                                State = state,
                                Zip = zip
                            };
                            contactDetails.AddContactDetails(contactDetail);
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("\nEnter E to edit Contact Details");
                            string? input2 = Console.ReadLine();

                            while (input2 == "E")
                            {
                                Console.WriteLine("\nEnter Mobile Number");
                                contactDetails.EditContactDetails(Convert.ToInt64(Console.ReadLine()));
                                
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("\nEnter D to Delete a Contact");
                            string? input3 = Console.ReadLine();

                            while (input3 == "D")
                            {
                                Console.WriteLine("\nEnter Mobile Number");
                                contactDetails.DeleteContact(Convert.ToInt64(Console.ReadLine()));
                                Console.WriteLine("Contact Deleted");
                                
                            }
                            break;
                        }

                    default:
                        {
                            flag = false;
                            break;
                        }
                }
                contactDetails.DisplayContact();
            }
        }
    }
}