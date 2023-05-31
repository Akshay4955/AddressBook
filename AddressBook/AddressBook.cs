using System.Collections;

namespace AddressBook;

public class AddressBook
{
    ArrayList addressBook = new ArrayList();
    public Contact CreateContact()
    {
        Console.WriteLine("Plz enter contact details");
        Contact contact = new();
        Console.WriteLine("Plz enter first name of contact");
        contact.firstName = Console.ReadLine();
        Console.WriteLine("Plz enter last name of contact");
        contact.lastName = Console.ReadLine();
        Console.WriteLine("Plz enter address of contact");
        contact.address = Console.ReadLine();
        Console.WriteLine("Plz enter city of contact");
        contact.city = Console.ReadLine();
        Console.WriteLine("Plz enter state of contact");
        contact.state = Console.ReadLine();
        Console.WriteLine("Plz enter zipCode of contact");
        contact.zipcode = Console.ReadLine();
        Console.WriteLine("Plz enter phoneNumber of contact");
        contact.phoneNumber = Console.ReadLine();
        Console.WriteLine("Plz enter email of contact");
        contact.email = Console.ReadLine();
        return contact;
    }

    public void AddContacts()
    {
        Console.WriteLine("Plz enter how many contacts you want to save");
        int noOfContacts = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < noOfContacts; i++) 
        {
            Contact contact = CreateContact();
            addressBook.Add(contact);
        }
    }

    public void PrintContacts()
    {
        foreach (Contact contact in addressBook)
        {
            Console.WriteLine(contact);
        }
    }
}
