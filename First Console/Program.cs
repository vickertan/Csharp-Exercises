Random dice = new();
int firstRoll = dice.Next();
int secondRoll = dice.Next(50);
int thirdRoll = dice.Next(51, 100);

Console.WriteLine($"First roll : {firstRoll}");
Console.WriteLine($"Second roll : {secondRoll}");
Console.WriteLine($"Third roll : {thirdRoll}");