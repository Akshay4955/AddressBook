namespace AddressBook;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to addressbook project...!!!");
        Console.WriteLine("--------------------------------------");
        AddressBook addressBook = new AddressBook();
        addressBook.AddContact();
        addressBook.EditContact();
        addressBook.DeleteContact();
    }
}
