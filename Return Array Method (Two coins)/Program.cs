﻿// Find multiple pairs of coins whose sum is equal to target value

int target = 50;
int[] coins = [5, 5, 50, 25, 25, 10, 5, 0];
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
  Console.WriteLine("No two coins make change");
}
else
{
  Console.WriteLine("Change found at positions: ");

  for (int i = 0; i < result.GetLength(0); i++)
  {
    if (result[i, 0] == -1) break;
    Console.WriteLine($"{result[i, 0]}, {result[i, 1]}");
  }
}

int[,] TwoCoins(int[] coins, int target)
{
  int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
  int count = 0;

  for (int curr = 0; curr < coins.Length; curr++)
  {
    for (int next = curr + 1; next < coins.Length; next++)
    {
      if (coins[curr] + coins[next] == target)
      {
        result[count, 0] = curr;
        result[count, 1] = next;
        count++;
      }

      if (count == result.GetLength(0)) return result;
    }
  }

  return count == 0 ? new int[0, 0] : result;
}