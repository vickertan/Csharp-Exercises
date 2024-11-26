string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
  // display internal email addresses
  string username = corporate[i, 0][..2].ToLower() + corporate[i, 1].ToLower();
  DisplayEmailAddress(username);
}

for (int i = 0; i < external.GetLength(0); i++)
{
  // display external email addresses
  string username = external[i, 0][..2].ToLower() + external[i, 1].ToLower();
  DisplayEmailAddress(username, externalDomain);
}

void DisplayEmailAddress(string name, string domain = "contoso.com")
{
  Console.WriteLine($"{name}@{domain}");
}
