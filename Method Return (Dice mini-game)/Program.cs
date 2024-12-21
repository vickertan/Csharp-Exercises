// Design a mini-game
Random random = new();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
  PlayGame();
}

bool ShouldPlay()
{
  string? input = Console.ReadLine();
  return input.ToLower().Equals("y");
}

void PlayGame()
{
  bool play = true;
  while (play)
  {
    int target = SetTarget();
    int roll = RollDice();

    Console.WriteLine($"Roll a number greater than {target} to win!");
    Console.WriteLine($"You rolled a {roll}");
    Console.WriteLine(WinOrLose(target, roll));
    Console.WriteLine("Play again? (Y/N)");

    play = ShouldPlay();
  }
}

int SetTarget()
{
  return random.Next(1, 6);
}

int RollDice()
{
  return random.Next(1, 7);
}

string WinOrLose(int target, int roll)
{
  return roll > target ? "You win!" : "You lose!";
}



/*
Would you like to play? (Y/N)
Y
Roll a number greater than 1 to win!
You rolled a 2
You win!

Play again? (Y/N)
Y
Roll a number greater than 4 to win!
You rolled a 6
You win!

Play again? (Y/N)
Y
Roll a number greater than 1 to win!
You rolled a 1
You lose!

Play again? (Y/N)
N
*/
