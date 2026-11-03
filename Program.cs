const decimal MinimumBalance = 1000.00m;

string accountHolder = "Aisha Bello";
string accountNumber = "0123456789";
string accountType = "Savings";
decimal balance = 50000.00m;
bool isActive = true;
DateTime openedOn = new DateTime(2026,1,10);


Console.WriteLine("================================");
Console.WriteLine("   VOSA BANK - ACCOUNT SUMMARY   ");
Console.WriteLine("================================");
Console.WriteLine($"Account holder : {accountHolder}");
Console.WriteLine($"Account Number : {accountNumber}");
Console.WriteLine($"Account Type : {accountType}");
Console.WriteLine($"Balance : {balance}");
Console.WriteLine($"Active : {isActive}");
Console.WriteLine($"Opened On : {openedOn:dd MMM yyyy}");
Console.WriteLine($"Minimum Balance : {MinimumBalance:N2}");
Console.WriteLine();

// Let's create a scenario where wh have to change the value of an existing variable
balance = balance + 15000.00m;
Console.WriteLine("Deposited NGN 15,000.00");
Console.WriteLine($"New Balance : NGN {balance:N2}");
