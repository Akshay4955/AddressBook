using Newtonsoft.Json;
using System.Collections;

namespace AddressBook;

public class AddressBookMain
{
    Dictionary<string, List<Contact>> AddressBookDictionary = new Dictionary<string, List<Contact>>();
    AddressBook addressBook = new AddressBook();
    string JSONFilePath = "B:\\BridgeLabz\\MicrosoftVisualStudio\\AddressBook\\File1.txt";

    public void CreateAddressBook()
    {
        ReadFromJSON();
        List<Contact> contacts = new List<Contact>();
        Console.WriteLine("Enter unique name for your addressbook ");
        string name = Console.ReadLine();
        if (name == "")
            Console.WriteLine("Plz enter valid name");
        else if (!AddressBookDictionary.ContainsKey(name))
        {
            AddressBookDictionary.Add(name, contacts);
            WriteToJSON();
        }   
        else
            Console.WriteLine("Entered key is already available. Plz try with different key.");
    }

    public void OperateExisting()
    {
        ReadFromJSON();
        Console.WriteLine("Enter key belong to address book");
        string inputKey = Console.ReadLine();
        if (AddressBookDictionary.ContainsKey(inputKey))
        {
            addressBook.AddressBookOperation(AddressBookDictionary[inputKey]);
            WriteToJSON();
        }
        else
            Console.WriteLine("AddressBook with entered key not available");
    }

    public void WriteToJSON()
    {
        string data = JsonConvert.SerializeObject(AddressBookDictionary, Formatting.Indented);
        File.WriteAllText(JSONFilePath, data);
        Console.WriteLine("Data written to Json file successfully..!!");
    }

    public void ReadFromJSON()
    {
        string data = File.ReadAllText(JSONFilePath);
        AddressBookDictionary = JsonConvert.DeserializeObject<Dictionary<string, List<Contact>>>(data);
        Console.WriteLine("Data reading from Json file successfully..!!");
    }
}
