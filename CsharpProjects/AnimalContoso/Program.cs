using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
void RandomizeAnimals()
{
    Random random = new Random();
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int j = random.Next(i, pettingZoo.Length);
        string temp = pettingZoo[j];
        pettingZoo[j] = pettingZoo[i];
        pettingZoo[i] = temp;

    }
}
RandomizeAnimals();
string[,] group = AssignGroup();
Console.WriteLine("School A");
PrintGroup(group);
string [,] AssignGroup(int group = 6)
{
     int index = 0;
    string [,] AnimalGroups = new string [group, pettingZoo.Length/group];
    for (int j = 0; j < group; j++)
    {
        for (int i = 0; i < pettingZoo.Length/group; i++)
        {
           
            AnimalGroups[j, i] = pettingZoo[index];
            index++;
        }

    }
    return AnimalGroups;
}
void PrintGroup(string [,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
       
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write(group[i, j]  + " ");
        }
        Console.WriteLine();
    }
}