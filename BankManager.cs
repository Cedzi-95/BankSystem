using System.ComponentModel;
public class BankManager
{
    public static void Execute(Bank bank, List<Account>Accounts)
    {
        string accountNumber = "";
        string accountHolder = "";
        decimal amount = 0;
        Account account = null;
try


{    while(true)
    {
        System.Console.WriteLine("Choose from the alternatives below: ");
        System.Console.WriteLine("Press 1 to create an account");
        System.Console.WriteLine("Press 2 for Deposition");
        System.Console.WriteLine("Press 3 for Withdrawing cash");
        System.Console.WriteLine("Press 4 to View balance");
        int choice = int.Parse(Console.ReadLine()!);
        
        switch(choice)
        {
            case 1: accountHolder = GetName();
            account = CreateAccount(bank, accountHolder);
            Accounts.Add(account);
            break;

            case 2: if(account != null)
            {
                Deposit(bank, account, GetAmount("Deposit"));
            }
            else
            {
                System.Console.WriteLine("Create an account first");
            }
            break;
            case 3:  if(account != null)
            {
                Withdraw(bank, account, GetAmount("Withdraw"));
            }
            else
            {
                System.Console.WriteLine("Create an account first");
            }
            break;
            case 4: if(account != null)
            {
                myBalance(bank, account);
            }
            else 
            {
                System.Console.WriteLine("Account not found");
            }
            break;
            default: System.Console.WriteLine("Wrong input");
            break;
        }


    }
}catch(Exception e)
{
    throw new ArgumentException("Invalid input. The error is " + e);
}
    }
    public static decimal GetAmount(string transaction)
    {
        System.Console.WriteLine($"Enter amount {transaction}");
        return decimal.Parse(Console.ReadLine()!);
    }
    public static string GetName()
    {
        System.Console.WriteLine("Enter account holders name: ");
        return Console.ReadLine()!;
    }

    public static Account CreateAccount(Bank bank, string accountHolder)
    {
        return bank.CreateAccount(accountHolder);
    }

    public static void Deposit(Bank bank, Account account, decimal amount)
    {
        Console.Clear();
        bank.Deposit(account.AccountNumber, amount);
        System.Console.WriteLine($"{amount} has been deposited in account {account.AccountNumber}");
        Console.ReadLine();
    }

    public static void Withdraw(Bank bank, Account account, decimal amount)
    {
        bank.Withdraw(account.AccountNumber, amount);

    }
    public static void myBalance(Bank bank, Account account)
    {
        bank.CheckBalance(account.AccountNumber, account.Balance);
        System.Console.WriteLine($"Your current balance: {account.Balance}");
        
    }
}

