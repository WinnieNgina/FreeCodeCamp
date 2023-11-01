using System.ComponentModel.DataAnnotations;

var address = "555..0.555";
void CheckAddress (string str)
{
    var splitted = str.Split(".");
    if (splitted.Length != 4)
    {
        Console.WriteLine("Not a valid IP4 address");
    }
    
    for(int i = 0; i < splitted.Length; i++)
    {
        string store = splitted[i];
        int number = 0;
        int.TryParse(splitted[i], out number);
        string num = number.ToString();
        if (num == store)
        {
            if (number >= 0 && number < 266)
            {
                if (i == 3)
                {
                    Console.WriteLine("Valid ip4 address");
                }
            }
        }
        else
        {
            Console.WriteLine("Not a valid IP4 address");
            break;
        }
        

    }
}
CheckAddress(address);
