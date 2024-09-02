// Example 1

// string? readResult;
// int userInt;

// bool validInput = false; // returns 'true' if user input is a valid representation of an integer.
// bool validInt = false; // validInt is integer between 5 and 10

// Console.WriteLine("Input an integer value between 5 and 10");
// do
// {
//   readResult = Console.ReadLine();
//   validInput = int.TryParse(readResult, out userInt);

//   if (!validInput)
//   {
//     Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     continue;
//   }

//   validInt = (userInt >= 5) && (userInt <= 10);

//   if (!validInt)
//   {
//     Console.WriteLine("Integer value must be between 5 and 10");
//     continue;
//   }
// } while (!validInt);

// Console.WriteLine($"Input accepted : {userInt}");

//  Example 2

string? readResult;
bool validInput = false;

do
{
  Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
  readResult = Console.ReadLine();
  string processedResult;

  if (readResult != null)
  {
    processedResult = readResult.Trim().ToLower();

    if (processedResult == "administrator" || processedResult == "manager" || processedResult == "user")
      validInput = true;
    else
      Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid.");
  }
} while (!validInput);

Console.WriteLine($"Your input value ({readResult}) has been accepted.");