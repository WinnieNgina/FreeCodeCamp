// bool flag = true;
// int value = 0;
// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside of code block: {value}");
// }
// Console.WriteLine($"Outside of code block: {value}");
//  A developer writes some code that includes an if statement code block. They initialize a first integer variable to a value of 1 above (outside) of the code block. 
//The Boolean expression for the if statement code block evaluates to true if the first integer variable has a value greater than 0. 
//The first code line inside of the code block is used to initialize a second integer variable to a value of 8. 
//The second code line inside the code block is used to assign the sum of the two integer values to the first variable. 
//The first code line after the code block is used to display the value of the first integer. What is the result when the code is executed? 
int var1 = 1;
if (var1 > 0)
{
    int var2 = 8;
    var1 += var2;
}