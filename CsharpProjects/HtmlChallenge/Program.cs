const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string searchdiv = "div";
int openingIndex = input.IndexOf(searchdiv);
if (openingIndex == - 1)
{
    System.Environment.Exit(400);
}
int closingIndex = input.LastIndexOf(searchdiv);
openingIndex += 4;
closingIndex -= 2;
int Length = closingIndex - openingIndex;
output = input.Substring(openingIndex, Length);
output = output.Replace("trade", "reg");
Console.WriteLine($"Output: {output}");
const string searchSpan = "span";
int openingSpan = input.IndexOf(searchSpan);
int closingSpan = input.LastIndexOf(searchSpan);
openingSpan += 5;
closingSpan -= 2;
int Lengthspan = closingSpan - openingSpan;
quantity = input.Substring(openingSpan, Lengthspan);
Console.WriteLine($"quantity: {quantity}");