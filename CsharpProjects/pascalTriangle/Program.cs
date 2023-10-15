// using System.Globalization;
// using System.Linq.Expressions;

// List<List<int>> myList = new List<List<int>>();
// List <int > triangleList = new List<int> ();
// triangleList.Add(1);
// myList.Add(triangleList);
// for (int i = 1; i < 5; i++)
// {
//     triangleList.Add(1);
//     for (int j = 1; j <= i; j++)
//     {
//         int element = myList[i - 1][j - 1] + myList[i -1][j];
//         triangleList.Add(element);
//     }
//     triangleList.Add(1);
//     myList.Add(triangleList);
// }

// foreach (List<int> subList in myList)
// {
//     var item = string.Join(" ",subList);
//     Console.WriteLine(item);
// }
static void PrintPascalsTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                int C = 1; // used to represent C(line, i)
                for (int j = 1; j <= line; j++)
                {
                    // Print spaces for the nice format
                    Console.Write(C + " ");
                    C = C * (line - j) / j; 
                }
                Console.WriteLine();
            }
        }
PrintPascalsTriangle(10);