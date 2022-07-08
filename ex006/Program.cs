Console.Write("Input user name: ");
string username = Console.ReadLine();
if(username.ToLower() == "kirill")
{
   Console.WriteLine("Hey Kirill");
}
else
{
   Console.Write("Hello, ");
   Console.WriteLine(username);
}