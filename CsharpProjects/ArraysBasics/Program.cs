/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

//object[] fraudulentOrderIDs = { "A123", "B456", "C789" , 1};
// With objects you can have mixed data types

//Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
//Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//fraudulentOrderIDs[0] = "F000";

//Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
//Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
//int[] inventory = { 200, 450, 700, 175, 250 };
//int sum = 0;
//int bin = 0;
//foreach (int inv in inventory)
//{
  //  bin++;
    //sum+=inv;
    //Console.WriteLine($"Bin {bin} = {inv} items (Running total: {sum})");  
//}
string [] OrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string OrderId in OrderIDs)
{
    if (OrderId.StartsWith("B"))
    {
        Console.WriteLine(OrderId);
    }
}




