using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.IlyinME.Sprint6.TaskReview.V20.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(int n, int m, int n1, int n2)
        {
            Random rnd = new Random();
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(n1, n2);
                    if (i % 2 != 0)
                    {
                        array[i, j] = (int)Math.Pow(array[i - 1, j], 3);
                    }
                }
            }
            return array;
        }

        public int ResultGetMatrix(int[,] array, int R, int K, int L)
        {
            int minElement = int.MaxValue;

            for (int j = K; j <= L; j++)
            {
                if (j % 2 == 0)
                {
                    if (array[R, j] < minElement)

                    {
                        minElement = array[R, j];
                    }
                }
            }

            return minElement;
        }
    }
}
