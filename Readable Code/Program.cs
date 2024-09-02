/*
This code reverse a string, count the number
of times a particular character appears, then
print it to the console window
*/

string originalMessage = "The quick brown fox jumps over the lazy dog";
char[] charMessage = originalMessage.ToCharArray();

// Reverse the string
Array.Reverse(charMessage);
string newMessage = new(charMessage);

// count the number of times a character appears
int letterCount = 0;
foreach (char letter in charMessage)
{
  if (letter == 'o')
  {
    letterCount++;
  }
}

// Display new message and number times a character appears
Console.WriteLine($"New message : {newMessage}");
Console.WriteLine($"'o' appears {letterCount} times.");