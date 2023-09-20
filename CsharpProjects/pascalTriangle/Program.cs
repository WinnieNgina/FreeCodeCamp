using System.Globalization;
using System.Linq.Expressions;

List<List<int>> myList = new List<List<int>>();
List <int > triangleList = new List<int> ();
myList.Append(triangleList);
for (int i = 1; i < 5; i++)
{
    triangleList.Add(1);
    for (int j = 1; j < i; i++)
    {
        int element = myList[i - 1][j - 1] + myList[i -1][j];
        triangleList.Append(element);
    }
    triangleList.Append(1);
    myList.Append(triangleList);
}

foreach (List<int> subList in myList)
{
    foreach (int item in subList)
    {
        Console.WriteLine(item);
    }
}