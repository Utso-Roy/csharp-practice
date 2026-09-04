class Linq
{
    public void LinqQuarry()
    {
        //     int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //     var count = array.Count();
        //     Console.WriteLine($"Count of Array {count}");

        //     var result = array.Where(x => x % 2 == 0).ToList();
        //     result[2] = 100;
        //     var sorting = result.OrderBy(x => x).ToList(); ;
        //     Console.WriteLine($"Shorting result = {string.Join(", ",sorting)}");

        // result.OrderBy(x => x).ToList().
        // Console.WriteLine($"Even numbers: {string.Join(", ", result)}");

        // List<List<int>> studentMarks = new List<List<int>>
        // {
        //     new List<int> { 85, 90, 78 },
        //     new List<int> { 92, 88, 95 },
        //     new List<int> { 76, 82, 89 }
        // };
        // var Marks = studentMarks.SelectMany(mark => mark);
        // Console.WriteLine($"Total Mark = {string.Join(", ", Marks)}");
        // Console.WriteLine($"type = {string .Join(", ",Marks.GetType())}");


        int[] array = { 2, 4, 5, 6, 7, 8, 9, 10 };
        var result = array.Any(x => x > 8);
        Console.WriteLine($" Any Number greater Than 8 = {result}");
        var result2 = array.All(x => x >= 2);
        Console.WriteLine($" All Numbers greater Than 8 = {result2}");
        var result3 = array.Contains(2);
        Console.WriteLine($" Contains 2 = {result3}");
       
        
    }
}