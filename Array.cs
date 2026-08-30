class Array
{
    public void LearnToArray()
    {
        int[] marks = { 80, 75, 90, 85 };
        // for (int i = 0; i < marks.Length; i++)
        // {
        //     Console.WriteLine($"Total Marks {marks[i]}");
        // }


            int sum = 0;

        foreach (int mark in marks)
        {
            sum += mark;
        }
        Console.WriteLine($"Total Sum = {sum}");
        
    }
}