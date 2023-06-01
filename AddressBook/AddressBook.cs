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

    public void AddContact()
    {
        Contact contact = CreateContact();
        addressBook.Add(contact);
        Console.WriteLine("Contact after adding contact");
        PrintContact();
    }

    public void EditContact()
    {
        Console.WriteLine("Plz enter the name whose contact you want to edit :");
        string name = Console.ReadLine();
        foreach (Contact contact in addressBook) 
        {
            if (contact.firstName == name)
            {
                Console.WriteLine("Plz enter which field you want to edit ");
                Console.WriteLine("Press 1 for First Name" + '\t' + "Press 2 for Last Name " + '\t' +
                    "Press 3 for address " + '\t' + "Press 4 for City " + '\t' + "Press 5 for State" +
                    '\t' + "Press 6 for Zip Code " + '\t' + "Press 7 for Phone Number " + '\t' +
                    "Press 8 for Email ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("Plz enter first name to be updated");
                        contact.firstName = Console.ReadLine();
                        break;
                    case 2: 
                        Console.WriteLine("Plz enter last name to be updated");
                        contact.lastName = Console.ReadLine();
                        break;
                    case 3: 
                        Console.WriteLine("Plz enter address to be updated");
                        contact.address = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Plz enter city to be updated");
                        contact.city = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Plz enter state to be updated");
                        contact.state = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Plz enter Zip Code to be updated");
                        contact.zipcode = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Plz enter Phone Number to be updated");
                        contact.phoneNumber = Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Plz enter email to be updated");
                        contact.email = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You entered wrong input");
                        break;
                }
                Console.WriteLine("Contact after editing contact");
                PrintContact();
                break;
            }
            else
            {
                Console.WriteLine("Contact not available with entered name to edit");
            }
        }
    }

    public void PrintContact()
    {
        foreach (Contact contact in addressBook)
        {
            Console.WriteLine("Contact present in addressbook : ");
            Console.WriteLine(contact);
        }
    }
}
