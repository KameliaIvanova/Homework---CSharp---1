/*
 * Problem 11. Bank Account Data
 * 
 * A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
 * IBAN, 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank account using the appropriate data types 
 * and descriptive names.
 */

using System;

namespace BankAccountData
{
    class Program
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Georgiev";
            string lastName = "Petrov";
            int money = 2000;
            string bankName = "OBB";
            long IBAN = 1234567885;
            string card1 = "000001010123";
            string card2 = "000002320492";
            string card3 = "000002448659";

            object account = "1 card: " + card1 + " 2 card: " + card2 + " 3 card: " + card3;

            Console.Write(firstName);
            Console.Write(middleName);
            Console.WriteLine(lastName);
            Console.WriteLine(money);
            Console.WriteLine(bankName);
            Console.WriteLine(IBAN);
            Console.WriteLine(account);
        }
    }
}
