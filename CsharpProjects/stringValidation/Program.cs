List <String> roles = new List<string> { "administrator", "manager", "user"};
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do {
    string? readInput = Console.ReadLine();
    if (readInput != null)
    {
        readInput = readInput.Trim();
        readInput = readInput.ToLower();
        bool validity = roles.Contains(readInput);
        if (validity == true)
        {
            Console.WriteLine($"Your input value ({readInput}) has been accepted.");
            break;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{readInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }
}while(true);
