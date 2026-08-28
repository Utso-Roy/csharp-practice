class TryCatch
{
    public TryCatch(string name)
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Invalid input: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Process completed.");
        }
    }
}