string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string (valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);