using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class Matrix
    {
        public static void rotate(int[,] m)
        {
            int n = m.GetLength(0);
            Console.WriteLine("Length is {0}",n);
            for (int t = 0; t < (n / 2); t++) {
                Console.Write(t+" ");
            }

        }
        public static void reach(int[,] m)
        {
            int n = m.GetLength(0);
            Console.WriteLine("Length is {0}", n);
            Console.WriteLine("{0}/2={1}",n, n/2);

            Console.WriteLine("Reach ");

            for (int t = 0; t < (n / 2); t++)
            {
                Console.Write(t + " ");
            }

        }

        public static int[,] createMatrix(int n) {
            Random r = new Random();
            int[,] m = new int[n,n];

            for (int i = 0; i < n; i++) {

                for (int j = 0; j < n; j++)
                {
                    m[i, j] = r.Next(1,10);

                }
            }
            return m;
        }

        public static void PrintMatrix(int [,]matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
           
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {

                    Console.Write("{0} ",matrix[i,j]);


                }
                Console.WriteLine("");

            }

        }

    }
}
