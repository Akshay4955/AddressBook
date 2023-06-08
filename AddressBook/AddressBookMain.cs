using System.Collections;

namespace AddressBook;

public class AddressBookMain
{
    Dictionary<string, ArrayList> AddressBookDictionary = new Dictionary<string, ArrayList>();
    AddressBook addressBook = new AddressBook();

    public void CreateAddressBook()
    {
        ArrayList contacts = new ArrayList();
        Console.WriteLine("Enter unique name for your addressbook ");
        string name = Console.ReadLine();
        if (name == "")
            Console.WriteLine("Plz enter valid name");
        else if (!AddressBookDictionary.ContainsKey(name)) 
            AddressBookDictionary.Add(name, contacts);
        else
            Console.WriteLine("Entered key is already available. Plz try with different key.");
    }

    public void OperateExisting()
    {
        Console.WriteLine("Enter key belong to address book");
        string inputKey = Console.ReadLine();
        if (AddressBookDictionary.ContainsKey(inputKey))
            addressBook.AddressBookOperation(AddressBookDictionary[inputKey]);
        else
            Console.WriteLine("AddressBook with entered key not available");
    }
}
