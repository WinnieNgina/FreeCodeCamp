string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
// Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int closingPosition = 0;
while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
    if (openingPosition == -1)
    {
        break;
    }
    string currentSymbol = message.Substring(openingPosition, 1);
    char matchingSymbol;
    if (currentSymbol == "[")
    {
        matchingSymbol = ']';
    }
    else if (currentSymbol == "{")
    {
        matchingSymbol = '}';
    }
    else
    {
        matchingSymbol = ')';
    }
    int matchingSymbolIndex = message.IndexOf(matchingSymbol);
    if (matchingSymbolIndex == -1)
    {
        continue;
    }
    int length = matchingSymbolIndex - openingPosition;
    Console.WriteLine(message.Substring(openingPosition + 1, length - 1));
    message = message.Substring(matchingSymbolIndex + 1);
}