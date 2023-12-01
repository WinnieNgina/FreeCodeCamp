// int division (int a, int b)
// {
//     return (a / b);
// }
// int result = division(1, 0);
/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

ChangeValue(x);

Console.WriteLine(x);

void ChangeValue(int value) 
{
   x = 10;
}