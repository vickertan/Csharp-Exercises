/* Exercise 1
string message = "Find what is <span>inside the span</span>";

const string openingSpan = "<span>";
const string closingSpan = "</span>";

int openingPosition = message.IndexOf(openingSpan);
int closingPosition = message.LastIndexOf(closingSpan);

openingPosition += openingSpan.Length;

int length = closingPosition - openingPosition;

string result = message.Substring(openingPosition, length);
Console.WriteLine(result);
*/

/* Exercise 2
string message = "(What if) there are (more than) one (set of parentheses)?";
const string openingSpan = "(";
const string closingSpan = ")";

while (true)
{
  int openingPosition = message.IndexOf(openingSpan);
  int closingPosition = message.IndexOf(closingSpan);
  if (openingPosition == -1 || closingPosition == -1) break;

  openingPosition += openingSpan.Length;

  int length = closingPosition - openingPosition;

  Console.WriteLine(message.Substring(openingPosition, length));

  message = message[(closingPosition + 1)..];
}
*/

/* Exercise 3
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = ['(', '[', '{'];
int closingPosition = 0;

while (true)
{
  int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
  if (openingPosition == -1) break;

  string currentSymbol = message.Substring(openingPosition, 1);
  char matchingSymbol = ' ';

  switch (currentSymbol)
  {
    case "(":
      matchingSymbol = ')';
      break;
    case "[":
      matchingSymbol = ']';
      break;
    case "{":
      matchingSymbol = '}';
      break;
  }

  openingPosition += 1;
  closingPosition = message.IndexOf(matchingSymbol, openingPosition);

  int length = closingPosition - openingPosition;
  Console.WriteLine(message.Substring(openingPosition, length));
}
*/

// Challenge 1
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Extract quantity
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openSpan) + openSpan.Length;
int closingPosition = input.IndexOf(closeSpan);
int length = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, length);
quantity = $"Quantity: {quantity}";

// Replace trademark symbol with registered trademark symbol 
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove opening <div> tag
const string openDiv = "<div>";
int openDivPoint = output.IndexOf(openDiv);
output = output.Remove(openDivPoint, openDiv.Length);

// Remove closing <div> tag
const string closeDiv = "</div>";
int closeDivPoint = output.IndexOf(closeDiv);
output = output.Remove(closeDivPoint, closeDiv.Length);
output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);
