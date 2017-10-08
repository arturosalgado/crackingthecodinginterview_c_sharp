using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class PalindromeNumber
    {

        public static bool isPalindrome(int number) {

            int div = 1;
            int result_division = 0;
            while ((result_division = (number / div)) >= 10) {
                div = div * 10;
            }
            while (number > 0) {

                int left = number / div;
                int right = number % 10;
                if (left != right)
                    return false;

                number = number % div / 10;


                div = div / 100;

            }
            return true;

        }
    }
}
