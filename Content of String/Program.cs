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

