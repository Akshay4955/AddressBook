using System.Collections;

namespace AddressBook;

public class AddressBook
{
    List<Contact> ContactAddressBook;

    public void AddressBookOperation(List<Contact> contacts)
    {
        ContactAddressBook = contacts;
        bool loop = true;
        while(loop)
        {
            Console.WriteLine("Plz enter what you want to perform : " + '\n' + "press 1 for add Contact" + '\n' + "press 2 for edit contact" + 
                            '\n' + "Enter 3 for print contact" + '\n' + "Enter 4 for delete contact" + '\n' + "Enter 0 to exit");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        EditContact();
                        break;
                    case 3:
                        PrintContact();
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 0:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("You entered wrong choice. Plz try with valid option");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Plz try with valid input");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
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
        Console.WriteLine("Plz enter how many contacts you want to add ");
        int noOfContacts = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < noOfContacts; i++)
        {
            Contact contact = CreateContact();
            ContactAddressBook.Add(contact);
        }
        Console.WriteLine("Contact after adding contact");
        PrintContact();
    }

    public void EditContact()
    {
        Console.WriteLine("Plz enter the name whose contact you want to edit :");
        string name = Console.ReadLine();
        foreach (Contact contact in ContactAddressBook) 
        {
            if (contact.firstName.Equals(name, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Plz enter which field you want to edit ");
                Console.WriteLine("Press 1 for First Name" + '\t' + "Press 2 for Last Name " + '\t' +
                    "Press 3 for address " + '\t' + "Press 4 for City " + '\t' + "Press 5 for State" +
                    '\t' + "Press 6 for Zip Code " + '\t' + "Press 7 for Phone Number " + '\t' +
                    "Press 8 for Email ");
                try
                {
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
                catch (FormatException) 
                {
                    Console.WriteLine("Plz try with valid input");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }
        
        Console.WriteLine("Contact not available with entered name to edit");
    }

    public void DeleteContact()
    {
        if (ContactAddressBook.Count == 0)
            Console.WriteLine("AddressBook is empty");
        else
        {
            Console.WriteLine("Plz enter the name whose contact you want to delete :");
            string name = Console.ReadLine();
            foreach (Contact contact in ContactAddressBook)
            {
                if (contact.firstName.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    ContactAddressBook.Remove(contact);
                    Console.WriteLine("Contact after deleting contact");
                    PrintContact();
                    break;
                }
            }

            Console.WriteLine("Contact not available with entered name to delete");
        }
    }

    public void PrintContact()
    {
        if (ContactAddressBook.Count == 0)
            Console.WriteLine("AddressBook is empty.");
        else
        {
            Console.WriteLine("Contact present in addressbook : ");
            foreach (Contact contact in ContactAddressBook)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
