Random random = new();
int luck = random.Next(100);

string[] text = ["You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"];
string[] good = ["look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"];
string[] neutral = ["appeciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."];
string[] bad = ["fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."];

WhisperFortune();

void WhisperFortune()
{
  Console.WriteLine("A fortune teller whispers the following words");
  string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));

  for (int i = 0; i < text.Length; i++)
  {
    Console.WriteLine($"{text[i]} {fortune[i]}");
  }
}
