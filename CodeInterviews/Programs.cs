using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class Programs
    {

        public static void callMatrix()
        {
            int[,] m = { { 1,2,3} ,
                         { 4,5,6},
                         { 7,8,9} };


            int[,] t =Matrix.createMatrix(4);
            Matrix.PrintMatrix(t);

            




            Console.ReadKey();

        }

        public static void call() {
            string s1 = "Papas";
            string s2 = "Pap";
            Console.WriteLine("One edit away {0} {1}",s1,s2);
            Console.WriteLine(OneEditAway.oneEdit(s1,s2));
            Console.ReadKey();

        }
        public static void call2()
        {
            string s1 = "Papas";
            string s2 = "Pap";
            OneEditAway.CheckDiff(s1, s2);
            Console.ReadKey();

        }
        public static void call3()
        {
            string s1 = "Casaaaaaaaaaaaaaaaaaaaaaaaa";

            int compressed = StringCompress.countCompress2(s1);
            int not_compressed = s1.Length;

            if (not_compressed <= compressed)
            {
                Console.WriteLine("No need to  compress");
                Console.Write(s1);
            }
            else {

                Console.Write("We will compress");
                Console.Write(StringCompress.compress(s1, compressed));
            }

            //Console.WriteLine("Lenght {0}", compressed);

        }
        public static void comp()
        {
           Console.Write( Utils.compareStringContent("casa","casa"));
        }

        public static void strings() {

            string[] strings = { "casa","abc","aa","c",""};
            foreach (var s in strings)
            {
                Console.WriteLine(Strings1.duplicateChars(s));
            }


        }

    }
}
