// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);
// Console.WriteLine(Object.ReferenceEquals(first, second));
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = @$"Dear {customerName},
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.
Currently, you own {currentShares:C} shares at a return of {currentReturn:P2}.

Our new product, Glorious Future offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.

Here's a quick comparison:

{currentProduct}         {currentReturn:P2}   {currentProfit:C}      
{newProduct}     {newReturn:P2}   {newProfit:C}";

Console.WriteLine(comparisonMessage);