class ArrayProperty
{
    public void Property()
    {
        int[] numbers = { 3, 35, 4, 6, 78, 89 };

        Console.WriteLine($"Total Sum Of Array = {numbers.Sum()}");
        Console.WriteLine($"Array Length = {numbers.Length}");
        Console.WriteLine($"Rank Of Array = {numbers.Rank}");
        Console.WriteLine($"GetLength Of Array = {numbers.GetLength(0)}");
        Console.WriteLine($"Max Value Of Array = {numbers.Max()}");
        Console.WriteLine($"Min Value Of Array = {numbers.Min()}");
        Console.WriteLine($"Average Value Of Array = {numbers.Average()}");
        Console.WriteLine($"Count Of Array = {numbers.Count()}");
        Console.WriteLine($"Found Of Array = {string.Join(", ", numbers.Where(x => x > 20))}");
    }
}