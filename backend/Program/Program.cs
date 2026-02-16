namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string? name = Console.Readline();
        Console.WriteLine($"Hello, {name}");
    }   
}
