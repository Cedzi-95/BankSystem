namespace OOP;

using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

class Program
{
  
    static void Main(string[] args)
    {

Bank bank = new Bank();
List<Account> Accounts = new List<Account>();
        System.Console.WriteLine();
        System.Console.WriteLine("Press enter to login...");
        Console.ReadKey();
        System.Console.WriteLine();
        System.Console.WriteLine("    WELCOME TO THE BANK ACCOUNT SYSTEM  ");
        System.Console.WriteLine();
BankManager.Execute(bank, Accounts);

               



    

        
  
    }      






    }



    



