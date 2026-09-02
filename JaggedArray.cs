
class JaggedArray
{
   public void Jagged()
   {
        int[][] numbers =
           {
            new []{1,2,3},
            new []{4,5},
            new []{6,7,8},
            new []{9,10,11,12},
        }; 

        foreach (var row in numbers)
        {
            foreach (var column in row)
            {
                Console.Write($"{column}" + " ");
            }
            Console.WriteLine();
            
        }
   } 
}