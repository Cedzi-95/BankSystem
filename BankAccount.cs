using System.Security.Cryptography.X509Certificates;

public class Account
{
    public string AccountNumber {get; set;}
    public string AccountHolder {get; set;}
    public decimal Balance {get; set;}
    
 //contstuctor
    public Account(string accountNumber, string accountHolder, decimal balance)
    {
        this.AccountHolder = accountHolder;
        this.AccountNumber = accountNumber;
        this.Balance = balance;
    }
    
    public decimal Deposit(decimal amount)
    {
        if(amount < 0)
        {
            throw new ArgumentException("Error. amount mustn´t be negative");
        }
         Balance += amount;
         return Balance;
    }

    public decimal? Withdraw(decimal amount)
    {

        if( Balance >= amount)
        {
           return Balance -= amount;        
        }
        else if (Balance < amount)
        {
            System.Console.WriteLine("Insufficient funds");
        }

            return null;
    }

    
}

public class Bank 
{
    private List<Account> Accounts = new List<Account>();

   


     public Account CreateAccount(string accountHolder)

    {
        string accountNumber = accountGenerator();
         Account newAccount = new Account(accountNumber, accountHolder, 0.0m);   
         Accounts.Add(newAccount);
        System.Console.Write($"Welcome to our bank system mr {accountHolder} \n");
        System.Console.Write($"your new account number is {accountNumber} \n");
        return newAccount;

    }
    private string accountGenerator()
    {
        Random random = new Random();
        return random.Next(10000, 90000).ToString();

    }
    public Account? GetAccount(string accountNumber)
    {

try

       { foreach(Account account in Accounts)
        {
            if(account.AccountNumber.Equals(accountNumber))
            {
                return account;
            }
            
        }
        }
        catch(Exception e)
        {
            System.Console.WriteLine("An issue has occured" +  e);
        }
        
        return null;
    }

    public decimal Deposit(string accountNumber, decimal amount)
    {
       Console.Clear();
       Account account = GetAccount(accountNumber);
       
        if(accountNumber == null || amount == null)
        {
            throw new ArgumentNullException("These fields can´t be null or empty");
        }
        
            return account.Deposit(amount);
        // System.Console.WriteLine($"Account number:{accountNumber} \n Holder: {accountHolder} \n Amount received: {input}");     
        // Console.ReadLine();
    
    }
    public void Withdraw(string accountNumber, decimal amount)
    {
        Console.Clear();
       Account account = GetAccount(accountNumber);
      

   
    try
   { 
    if (account.Balance >=  amount)
    {
        account.Withdraw(amount);
       System.Console.WriteLine($" {amount} has been withdrawn from account: {accountNumber}");
    }
    else
    {
        System.Console.WriteLine("Insufficient funds.");
        Console.ReadKey();
    }
    } catch(Exception e)
    {
        System.Console.WriteLine("The issue is" + e);
    }
       
        
    }
    public decimal? CheckBalance(string accountNumber, decimal balance)
    {
        Console.Clear();
        foreach(Account account in Accounts)
        {
            if(account.AccountNumber.Equals(accountNumber))
        {
            return account.Balance;
        }
       }
       return null;
    }

}