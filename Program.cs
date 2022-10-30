using AddressBook.Model;
using AddressBook.Repository;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            ContactDetailsRepository contactDetails = new ContactDetailsRepository();
            contactDetails.AddContactDetails("Rahul", "Kumar", 9999999999, "rk@gmail.com", "Yehlanka", "Banglore", "Karnataka", 560064);
            contactDetails.DisplayContact();
            Console.ReadLine();
        }
    }
}
