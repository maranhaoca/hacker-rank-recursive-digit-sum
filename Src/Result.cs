using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'superDigit' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING n
         *  2. INTEGER k
         */

        public static int superDigit(string n, int k)
        {
            string trimmed = String.Concat(n.Where(c => !Char.IsWhiteSpace(c)));

            while (trimmed.Count() > 1)
            {
                var sum = trimmed.Sum(el => Int32.Parse(el.ToString()));
                trimmed = Convert.ToString(sum);                
            }

            int p = Int32.Parse(trimmed.ToString()) * k;
            string pString = Convert.ToString(p);

            while (pString.Count() > 1)
            {
                var sum = pString.Sum(el => Int32.Parse(el.ToString()));
                pString = Convert.ToString(sum);                
            }            

            return Convert.ToInt32(pString);
        }
    }
}