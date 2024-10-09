// Challenge to parse a string of orders, sort the orders and tag possible errors

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] order_IDs = orderStream.Split(",");
Array.Sort(order_IDs);

for (int i = 0; i < order_IDs.Length; i++)
{
  if (order_IDs[i].Length == 4)
    Console.WriteLine(order_IDs[i]);
  else
    Console.WriteLine($"{order_IDs[i]}\t- Error");
}
