// string Sentence = "";
// decimal numeric = 0m;
// decimal sum = 0m;
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// bool check = false;
// foreach (var value in values)
// {
//     check = decimal.TryParse(value, out numeric);
//     if (check == true)
//     {
//         sum +=numeric;
//     }
//     else
//     {
//         Sentence += value; 
//     }
// }
// Console.WriteLine($"Message: {Sentence}");
// Console.WriteLine($"Total: {sum}");
// int sums (int a, int b)
// {
//     return (a + b);
// }
// int value = sums(10, 5);
// Console.WriteLine(value);
var values = (int a, int b) => {return a + b;};
Console.WriteLine(values(10, 5));
