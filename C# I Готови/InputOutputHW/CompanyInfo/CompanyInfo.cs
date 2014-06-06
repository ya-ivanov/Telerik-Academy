using System;

class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Enter company name:");
        string CompanyName = Console.ReadLine();
        Console.WriteLine("Enter company's address:");
        string Address = Console.ReadLine();
        Console.WriteLine("Enter company's Phone Number:");
        string PhoneNbr = Console.ReadLine();
        Console.WriteLine("Enter company's Fax Number:");
        string FaxNbr = Console.ReadLine();
        Console.WriteLine("Enter company's website:");
        string WebSite = Console.ReadLine();
        Console.WriteLine("Enter Manager's name:");
        string ManagerFirstName = Console.ReadLine();
        Console.WriteLine("Enter Manager's last name:");
        string ManagerLastName = Console.ReadLine();
        string ManagerFullName = ManagerFirstName + " " + ManagerLastName;
        Console.WriteLine("Enter Manager's age:");
        byte ManagerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter Manager's phone number:");
        string ManagerPhoneNbr = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Company Name: {0}", CompanyName);
        Console.WriteLine("Address: {0}", Address);
        Console.WriteLine("Phone Number: {0}", PhoneNbr);
        Console.WriteLine("Fax Number: {0}", FaxNbr);
        Console.WriteLine("Website: {0}", WebSite);
        Console.WriteLine("Manager's name: {0}", ManagerFullName);
        Console.WriteLine("Manager's age: {0}", ManagerAge);
        Console.WriteLine("Manager's Phone number: {0}", ManagerPhoneNbr);
    }
}

