using System.ComponentModel.Design;

const decimal dailyLimit = 50000m;
decimal balance = 50000.00m;

Console.WriteLine("================================");
Console.WriteLine("         VOSA Bank");
Console.WriteLine("================================");
Console.WriteLine("1. Check balance");
Console.WriteLine("2. Deposit");
Console.WriteLine("3. Withdraw");
Console.WriteLine("4. Exit");
Console.WriteLine();
Console.Write("Choose an option");

string choice = (Console.ReadLine() ?? "").Trim();
Console.WriteLine();

switch (choice)
{
    case "1" :
    Console.WriteLine($"Your balance is NGN {balance:N2}");
    break;

    case "2":
    Console.WriteLine("Amount to deposit: ");
    string depositInput = Console.ReadLine() ?? "";

    if (!decimal.TryParse(depositInput, out decimal depositAmount))
        {
            Console.WriteLine("That is not a valid amount.");
        }
    else if (depositAmount <= 0m)
        {
            Console.WriteLine("The deposit must be more than zero");
        }    
    else
        {
            balance = balance + depositAmount;
            Console.WriteLine($"Deposited NGN {depositAmount: N2}");
            Console.WriteLine($"New balance: NGN {balance:N2}");
        }    
        break;
        
    case "3":
    Console.Write("Amount to withdraw: ");
    string withdrawInput = Console.ReadLine() ?? "";

    if (!decimal.TryParse(withdrawInput, out decimal withdrawAmount))
        {
            Console.WriteLine("That is not a valid amount. ");
        }
    else if (withdrawAmount <= 0m)
        {
            Console.WriteLine("The amount must be more thatn zero. ");
        
        }
    else if (withdrawAmount > dailyLimit)
        {
            Console.WriteLine("Insuffficient funds.");
        }            
    else
        {
            balance -= withdrawAmount;
            Console.WriteLine($"Please take your case: NGN {withdrawAmount:N2}");
            Console.WriteLine($"New balance: NGN {balance:N2}");
        }
        break;

    case "4" :
    Console.WriteLine("Thank you for banking with VOSA bank. Goodbye!");
    break;

    default: 
    Console.WriteLine($"'{choice}'is not a valid option. please choose 1 to 4." );  
    break; 
    
        
}