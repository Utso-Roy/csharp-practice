// Practice inheritance, Shallow Copy and DeepCopy
class ShallowCopy
{
    protected int[] originalArray = { 1, 2, 3, 4, 5, 6, 7 };
    public void ShallowCopyPractice()
    {

        int[] shallowCopyArray = originalArray;
        shallowCopyArray[1] = 20;
        Console.WriteLine($"OriginalArray = {string.Join(", ", originalArray)}");
        Console.WriteLine($"ShallowCopyArray = {string.Join(", ", shallowCopyArray)}");
    }
}


class DeepCopy:ShallowCopy
{
    public void DeepCopyPractice()
    {
        int[] deepCopyArray = new int[originalArray.Length];
      System.Array.Copy(originalArray, deepCopyArray, originalArray.Length);
        deepCopyArray[2] = 80;
        Console.Write($"DeepCopyArray = {string.Join(", ", deepCopyArray)}");
        Console.WriteLine();
        
        
    }
}