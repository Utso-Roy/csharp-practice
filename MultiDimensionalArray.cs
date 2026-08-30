class MultiDimensionArray
{
    public void MultiDimension()
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int row = 0; row < 2; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                Console.Write(matrix[row, column] + " ");

            } 
           
           Console.WriteLine();
           
        }
       
    }
}