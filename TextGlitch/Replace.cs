using System;
using System.Linq;
using System.Threading;

namespace TextGlitch
{
    public class Replace
    {
        public static string Text(string originalText)
        {
            if (originalText == "")
            {
                return "Nothing to replace.";
            }
            char[] textInput1 = new char[originalText.Length];
            char[] textInput2 = new char[originalText.Length];
            textInput1 = originalText.ToCharArray();
            return textReplacing(textInput1, textInput2);
        }
        private static string textReplacing(char[] textInput1, char[] textInput2)
        {
            int[] rand2;
            Random rnd = new Random();
            rand2 = random(textInput1.Length, rnd);
            for (int i = 0; i < textInput1.Length; i++)
            {
                textInput2[i] = textInput1[rand2[i]];
            }
            string textOut = new string(textInput2);
            return textOut;
        }
        private static int[] random(int rand, Random rnd)
        {
            int[] mas = new int[rand];
            for (int i = 0; i < rand; i++)
            {
                mas[i] = -1;
            }
            for (int i = 0; i < rand; i++)
            {
                int a = rnd.Next(0, rand);
                if (!mas.Contains(a))
                {
                    mas[i] = a;
                }
                else
                    i--;
            }
            return mas;
        }
    }
}
