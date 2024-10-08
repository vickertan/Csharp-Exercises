// Challenge to reverse words in sentence (Challenge 1)
string pangram = "The quick brown fox jumps over the lazy dog";

// Create an array of words in pangram
string[] pangramWord = pangram.Split(" ");

// Create an array to store reversed pangram word
string[] reversedPangramWord = new string[pangramWord.Length];

// Iterate through each word
for (int i = 0; i < pangramWord.Length; i++)
{
  char[] wordChar = pangramWord[i].ToCharArray();
  Array.Reverse(wordChar);
  reversedPangramWord[i] = new string(wordChar);
}

string result = String.Join(" ", reversedPangramWord);

Console.WriteLine(result);
