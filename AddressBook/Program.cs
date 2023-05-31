namespace AddressBook;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to addressbook project...!!!");
        Console.WriteLine("Plz enter contact details");
        Contact contact = new ();
        Console.WriteLine("Plz enter first name of contact");
        contact.firstName =  Console.ReadLine();
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
        Console.WriteLine(contact.ToString());
    }
}
