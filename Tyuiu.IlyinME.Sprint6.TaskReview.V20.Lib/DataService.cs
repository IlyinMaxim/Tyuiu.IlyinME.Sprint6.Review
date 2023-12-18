using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.IlyinME.Sprint6.TaskReview.V20.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(int n, int m, int n1, int n2, int K, int L, int R)
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
                        array[i, j] = (int)Math.Pow(array[i-1, j], 3);
                    }
                }
            }
            if (n1 >= n2 || K >= L || R < 0 || R >= n || K < 0 || K >= m || L < 0 || L >= m)
            {
                Console.WriteLine("Некорректные входные данные!");
            }
            return array;
        }
            
        public int ResultGetMatrix(int[,] array, int R, int K, int L)
        {
            int minElement = array[R, K];

            for (int i = K; i <= L; i += 2)
            {
                if (array[R, i] < minElement)
                {
                    minElement = array[R, i];
                }
            }

            return minElement;
        }
    }
}
