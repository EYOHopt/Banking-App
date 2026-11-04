string accountHolder = "Aisha Bello";
decimal balance = 50000.00m;


Console.WriteLine("================================");
Console.WriteLine("         VOSA Bank");
Console.WriteLine("================================");

Console.Write("Enter your first name: ");
string firstName = Console.ReadLine() ?? "";
Console.WriteLine($"Welcome: {firstName}");
Console.WriteLine($"Current Balance : {balance:N2}");
Console.WriteLine();

Console.Write("How much do you want to deposit? ");
string input = Console.ReadLine() ?? "";

bool isValid = decimal.TryParse(input, out decimal depositAmount);

bool isPositive = depositAmount > 0m;
bool canDeposit = isValid && isPositive;

Console.WriteLine($"is it a number?  {isValid}");
Console.WriteLine($"Is it more than zero?   {isPositive}");
Console.WriteLine($"Deposit Allowed?   {canDeposit}");
Console.WriteLine();


balance += depositAmount;
Console.WriteLine ($"New balance: NGN {balance:N2}");