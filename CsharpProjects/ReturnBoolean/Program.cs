string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}
bool IsPalindrome (string word)
{
    char [] ReverseChar = word.ToCharArray();
    string reversedString = string.Empty;
    for (int i = ReverseChar.Length - 1; i >= 0; i--)
    {
        reversedString += ReverseChar[i]; 
    }
    var finalString = new string(reversedString);
    return string.Equals(word, finalString);   
}