// string pangram = "The quick brown fox jumps over the lazy dog";
// var ArrayofStrings = pangram.Split(" ");
// string toPrint = "";
// foreach (var str in ArrayofStrings)
// {
//     var reverseStr = str.ToCharArray();
//     Array.Reverse(reverseStr);
//     toPrint += new string (reverseStr);
//     toPrint += " ";
// }
// Console.WriteLine(toPrint);
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
var orderIds = orderStream.Split(",");
Array.Sort(orderIds);
foreach (var item in orderIds)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine($"{item} \t- Error");
    }
}