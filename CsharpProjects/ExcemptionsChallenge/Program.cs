string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

string overallStatusMessage = "";

try {
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    //Console.WriteLine(overallStatusMessage);
}

static void Workflow1(string[][] userEnteredValues)
{
    // string operationStatusMessage = "good";
    string processStatusMessage = "";

    foreach (string[] userEntries in userEnteredValues)
    {
        try {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            //Console.WriteLine(processStatusMessage);
            Console.WriteLine();
            // operationStatusMessage = processStatusMessage;
        }
    }

    // if (operationStatusMessage == "good")
    // {
    //     operationStatusMessage = "operating procedure complete";
    // }

    // return operationStatusMessage;
}

static void Process1(String[] userEntries)
{
    string processStatus = "clean";
    string returnMessage = "";
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try 
        {
            valueEntered = int.Parse(userValue);
            int calculatedValue = 4 / valueEntered;
        }
        catch (DivideByZeroException ex){
            Console.WriteLine($"{ex.Message}");
            throw;

        }
        catch (FormatException ex)
        {
            Console.WriteLine($"{ex.Message}");
            throw;
        }
    }

    if (processStatus == "clean")
    {
        Console.WriteLine("process complete");
    }
}