using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGlitch
{
    public class Reverse
    {
        public static string Text(string originalText)
        {
            if (originalText == "")
            {
                return "Nothing to reverse.";
            }
            char[] reverseOrig = originalText.ToCharArray();
            return reverseProcess(reverseOrig);
        }
        private static string reverseProcess(char[] reverseOrig)
        {
            int e = 0;
            char[] reverse = new char[reverseOrig.Length];
            for (int i = 0; i < reverseOrig.Length; i++)
            {
                reverse[i] = reverseOrig[reverseOrig.Length - e - 1];
                e++;
            }
            string reverseOut = new string(reverse);
            return reverseOut;
        }
    }
}
