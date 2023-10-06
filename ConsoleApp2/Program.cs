using System.Drawing;

Console.Write("Write your password: ");
string password = Console.ReadLine();
int score = 0;
if (password == String.Concat(password.Where(c => !Char.IsWhiteSpace(c))))
{
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Password has blank spaces! Try again!");
    Console.ResetColor();
    Environment.Exit(0);
}
if (password.Length >= 8)
    score = score + password.Length * 5;
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Password is less than 8 symbols! The password is really weak");
    Console.ResetColor();
    Environment.Exit(0);
}
if (password == password.ToLower() || password == password.ToUpper()) { }
else
{
    score = score +10;
}
if (password.Any(ch => !char.IsLetterOrDigit(ch)))
{
    score = score + 10;
}
if (score == 40)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Password is very weak");
    Console.ResetColor();
}
else if (score <= 50)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Password is weak");
    Console.ResetColor();
}
else if (score <= 60)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Password is strong");
    Console.ResetColor();
}
else if (score > 60)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Password is very strong");
    Console.ResetColor();
}
else { }


