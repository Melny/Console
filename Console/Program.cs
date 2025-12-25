// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"Iteration {i + 1}");
}

if (DateTime.Now.Hour < 12)
{
    Console.WriteLine("Good morning!");
}
else
{
    Console.WriteLine("Good afternoon!");
}