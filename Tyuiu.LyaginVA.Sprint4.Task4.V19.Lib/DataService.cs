using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LyaginVA.Sprint4.Task4.V19.Lib
{
    public class DataService : ISprint4Task4V19
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i,j] < 1)
                    {
                        return 0;
                    }
                    if (matrix[i, j] > 8)
                    {
                        return 0;
                    }
                    if (matrix[i, j] % 2 == 1)
                    {
                        count += matrix[i, j];
                    }




                }
            }
            return count;
        }
    }
}
