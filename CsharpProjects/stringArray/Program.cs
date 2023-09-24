using Microsoft.VisualBasic;

string[] myStrings = new string[2] { "I like pizza.    I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;
foreach(string myString in myStrings)
{
    string String = myString;
    periodLocation = String.IndexOf('.');
    while (String != null)
    {
        if (periodLocation != -1)
        {
            Console.WriteLine(String.Remove(periodLocation));
            string UpdateString = String.Substring(periodLocation + 1);
            UpdateString = UpdateString.TrimStart();
            periodLocation = UpdateString.IndexOf('.');
            String = UpdateString;
        }
        else
        {
            Console.WriteLine(String);
            break;
        }
    }
}