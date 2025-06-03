namespace DoLoopHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? firstName = "";
            while (firstName.ToLower() != "exit")
            {
                Console.Write("What is your name: ");
                firstName = Console.ReadLine();
                switch (firstName.ToLower())
                {
                    case "tim" or "timothy":
                        Console.WriteLine($"Hello Professor {firstName}");
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine($"Hello student {firstName}");
                        break;
                }
            };
        }
    }
}
