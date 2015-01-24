/*
 * Problem 2. Print Company Information
 * 
 * A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, 
 * age and a phone number.
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;

namespace _02_PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.Write("Fax number: ");
            int fax = int.Parse(Console.ReadLine());
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager age: ");
            byte age = byte.Parse(Console.ReadLine());
            Console.Write("Manager phone: ");
            long managerPhone = long.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel.: " + phoneNumber);
            Console.WriteLine("Fax: " + fax);
            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);

        }
    }
}
