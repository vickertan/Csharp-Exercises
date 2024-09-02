string permission = "Admin|Manager";
int level = 19;

string message = "";

if (permission.Contains("Admin"))
{
  if (level > 55)
    message = "Welcome, Super Admin user.";
  else
    message = "Welcome, Admin user.";
}
else if (permission.Contains("Manager") && level > 19)
{
  message = "Contact an Admin for access.";
}
else
{
  message = "You do not have sufficient privileges.";
}

Console.WriteLine(message);