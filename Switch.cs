public class SwitchExample
{    public static void Run()
    {
        int digit = 2;
        string message = digit switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            _ => "Unknown"
        };
        // Console.ReadKey();
        Console.WriteLine(message);
    }
}