
// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);
// int number = 1032;
// byte b = (byte)number;
// Console.WriteLine(b);
// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);
char value = 'a';
int result = 0;
if (int.Parse(value))
{
    Console.WriteLine($"Measurement is True");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

Console.WriteLine($"Measurement (w/ offset): {50 + result}");