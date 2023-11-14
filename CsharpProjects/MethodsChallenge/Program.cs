Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = Target();
        var roll = Roll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}
bool ShouldPlay()
{
    string playInput = Console.ReadLine();
    return playInput.ToLower() == "y" ? true : false; 
}
string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    else
    {
        return "You lose!";
    }
}
int Target()
{
    int target = random.Next(1, 6);
    return target; 
}
int Roll()
{
    int roll = random.Next(1, 7);
    return roll;
}
