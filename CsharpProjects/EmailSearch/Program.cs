string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "@hayworth.com";
void DisplayInternalEmails()
{

    for (int i = 0; i < corporate.GetLength(0); i++) 
    {
        // display internal email addresses
        string twochars = corporate[i, 0].Substring(0, 2);
        string conc = twochars + corporate[i, 1] + "@contoso.com";
        Console.WriteLine(conc.ToLower());
    }
}
void DisplayExternalEmails()
{
    for (int i = 0; i < external.GetLength(0); i++)
    {
        string twochars = corporate[i, 0].Substring(0, 2);
        string conc = twochars + corporate[i, 1] + externalDomain;
        Console.WriteLine(conc.ToLower());
    }
}
DisplayInternalEmails();
DisplayExternalEmails();
