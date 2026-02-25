using System;
using Contact_manager.Components;
using Contact_manager.Services;
class Program
{
    static void Main()
    {
        IService service = new ServiceV1();
        service.Load();

        Console.WriteLine("Welcome to contact management system of microsoft");
        while (true)
        {
            Console.WriteLine("\n1.Add\n2.Edit\n3.Delete\n4.View\n5.List");
            Console.WriteLine("6.Search\n7.Filter\n8.Save\n9.Exit\n");
            Console.Write("Choose: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":// Add //
                    Console.Write("Name: ");
                    var name = Console.ReadLine();
                    Console.Write("Phone: ");
                    var phone = Console.ReadLine();
                    Console.Write("Email: ");
                    var email = Console.ReadLine();
                    service.AddContact(name, phone, email);
                    break;

                case "2": // Edit
                    int id;
                    while (true)
                    {
                        Console.Write("Write the id of the mentioned contact : ");
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out id))
                            break;
                        else
                            Console.WriteLine("Invalid input! Please enter a valid id.");
                    }
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Phone: ");
                    phone = Console.ReadLine();
                    Console.Write("Email: ");
                    email = Console.ReadLine();
                    service.EditContact(id, name, phone, email);
                    break;

                case "3"://Delete //
                    while (true)
                    {
                        Console.Write("Write the id of the mentioned contact : ");
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out id))
                            break;
                        else
                            Console.WriteLine("Invalid input! Please enter a valid id.");
                    }
                    service.DeleteContact(id);
                    break;

                case "4":// View 
                    while (true)
                    {
                        Console.Write("Write the id of the mentioned contact : ");
                        string input = Console.ReadLine();
                        if (int.TryParse(input, out id))
                            break;
                        else
                            Console.WriteLine("Invalid input! Please enter a valid id.");
                    }
                    Contact  C = service.GetContact(id);
                    
                    if (C != null)
                        C.Print();
                    else
                        Console.WriteLine("Wrong ID");

                    break;
                case "5"://List //
                    foreach (var c in service.GetAllContacts())  
                        c.Print();
                    break;

                case "6":// Search //
                    Console.Write("Keyword: ");
                    var key = Console.ReadLine();
                    foreach (var c in service.Search(key))
                        c.Print();
                    break;

                case "7"://filter by date //
                    Console.Write("Date (yyyy-mm-dd): ");
                    DateTime d = DateTime.Parse(Console.ReadLine());
                    foreach (var c in service.FilterByDate(d))
                        c.Print();
                    break;

                case "8":// save data in json //
                    service.Save();
                    Console.WriteLine("Saved.");
                    break;

                case "9":// exit //
                    Console.WriteLine("Thanks for using our application");
                    return;
            }
        }
        
    }

   
}

