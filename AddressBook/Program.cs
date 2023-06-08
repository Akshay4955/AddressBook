namespace AddressBook;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to addressbook project...!!!");
        Console.WriteLine("--------------------------------------");
        
        AddressBookMain addressBookMain = new AddressBookMain();
        bool loop = true;
        while(loop)
        {
            Console.WriteLine("Plz enter what you want to perform :");
            Console.WriteLine("Press 1 to create new address book" + '\n' + "Press 2 to perform operation on existing address book" + 
                            '\n' + "Press 0 to exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    addressBookMain.CreateAddressBook();
                    break;
                case 2:
                    addressBookMain.OperateExisting();
                    break;
                case 0:
                    loop = false;
                    break;
                default:
                    Console.WriteLine("You entered wrong input. plz try with valid input");
                    break;
            }
        }
        
    }
}
