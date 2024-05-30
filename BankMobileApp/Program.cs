
using MyBankMobileApp;
using System.Text;
using System.Text.RegularExpressions;

Account myAccount2 = new Account();
Account destinationAccount = new Account(); // For transfer example

Account myAccount = new Account();
Console.WriteLine("Enter your first name: ");
string firstName = Console.ReadLine();
while (string.IsNullOrEmpty(firstName) || !Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
{
    firstName = Console.ReadLine();
    if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
    {
        Console.WriteLine("Invalid input. Please enter only alphabetic characters for the first name.");
    }
}
Console.WriteLine("Enter your last name: ");
string lastName = Console.ReadLine();
while (string.IsNullOrEmpty(lastName) || !Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
{
    lastName = Console.ReadLine();
    if (!Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
    {
        Console.WriteLine("Invalid input. Please enter only alphabetic characters for the last name.");
    }
}
Console.WriteLine("Enter your phone number: ");
string phoneNumber = Console.ReadLine();
// Validate the input
if (IsValidPhoneNumber(phoneNumber))
{
    myAccount.PhoneNumber = phoneNumber;
    Console.WriteLine($"Phone number set to: {myAccount.PhoneNumber}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a phone number starting with '+' followed by numbers.");
}
    // Function to validate the phone number using a regular expression
    static bool IsValidPhoneNumber(string phoneNumber)
{
    // Define a regular expression pattern that matches phone numbers starting with '+' followed by numbers
    string pattern = @"^\+\d+$";

    // Use Regex.IsMatch to check if the input string matches the pattern
    return Regex.IsMatch(phoneNumber, pattern);
}
Console.WriteLine("Enter your email: ");
myAccount.Email = Console.ReadLine();
Console.WriteLine("Select account type: 0 for Savings, 1 for Current, and 2 for Corporate");
string[] AccountType = new string[3];
AccountType[0] = "Savings";
AccountType[1] = "Current";
AccountType[2] = "Corporate";
// Get user input
int choice;
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 2)
    {
        Console.WriteLine("Invalid input. Please enter 0, 1, or 2.");
    }

    // Store the selected account type
        string selectedAccountType = "";
        switch (choice)
        {
        case 0:
            selectedAccountType = AccountType[0];
            break;
        case 1:
            selectedAccountType = AccountType[1];
            break;
        case 2:
            selectedAccountType = AccountType[2];
            break;
        }
Console.WriteLine($"Selected account type: {selectedAccountType}");
Random random = new Random();
var AccountNumberGenerated = random.Next(10000000, 999999999);
Console.WriteLine($"Your account number is: " +  AccountNumberGenerated);

    
    Console.WriteLine("Select transaction: 0 - Deposit, 1 - Withdrawal, 2 - Transfer, 3 - Balance");
    string[] TransactionType = new string[4];
    TransactionType[0] = "Deposit";
    TransactionType[1] = "Withdrawal";
    TransactionType[2] = "Transfer";
    TransactionType[3] = "Balance";
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 3)
    {
        Console.WriteLine("Invalid input. Please enter 0, 1, 2, or 3");
    }
    // Store the selected account type
    string selectedTransactionType = "";
    switch (choice)
    {
        case 0:
        selectedTransactionType = TransactionType[0];
            break;
        case 1:
        selectedTransactionType = TransactionType[1];
            break;
        case 2:
        selectedTransactionType = TransactionType[2];
            break; 
        case 3:
        selectedTransactionType = TransactionType[3];
            break;
    }
    Console.WriteLine($"Selected account type: {selectedTransactionType}");
Random random2 = new Random();
myAccount.AccountNumberGenerated = random.Next(10000000, 999999999).ToString(); 
Console.WriteLine($"Your account number is: {myAccount.AccountNumberGenerated}");
destinationAccount.AccountNumberGenerated = random2.Next(10000000, 999999999).ToString();
destinationAccount.CurrentAccountBalance = 5000; //Note this later
while (true)
{
    Console.WriteLine("Select transaction: 0 - Deposit, 1 - Withdrawal, 2 - Transfer, 3 - Balance");
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 3)
    {
        Console.WriteLine("Invalid selection. Please select from 0 to 3");
    }

    if (choice == 3) break;
    switch (choice)
    {
        case 0:
            Console.WriteLine("Enter amount to deposit: ");
            break;
        case 1:
            Console.WriteLine("Enter amount to withdraw: ");
            break;
        case 2:
            Console.WriteLine("Enter amount to transfer: ");
            break;
    
    }       
 }







