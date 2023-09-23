int number;
bool numValidity;
Console.WriteLine("Enter an integer value between 5 and 10");
string? readResult = Console.ReadLine();
numValidity = int.TryParse(readResult, out number);
// The string converted to int is assigned to number
// the boolean returned on whether true or false is assigned to numValidity
while (number < 5 || number > 10 || numValidity == false)
{
    if (numValidity == false)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        readResult = Console.ReadLine();
        numValidity = int.TryParse(readResult, out number);
    }
    if (number < 5 || number > 10)
    {
        Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
        readResult = Console.ReadLine();
        numValidity = int.TryParse(readResult, out number);
    }
}
Console.WriteLine($"Your input value ({number}) has been accepted.");
