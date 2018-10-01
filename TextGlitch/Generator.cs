using System;
using System.Threading;

namespace TextGlitch
{
    public class Generate
    {
        private static int Randomize(int b, Random rand)
        {
            int rand2;
            rand2 = rand.Next(0, Convert.ToInt32(b));
            return rand2;
        }
        public static string TextAndNumbers(int lenghtOfGenerated)
        {
            if (lenghtOfGenerated <= 0)
            {
                return "Incorrect values.";
            }
            char[] letters = InitializeLetters();
            char[] smallLetters = InitializeSmallLetters();
            char[] numbers = InitializeNumbers();
            char[] generated = new char[lenghtOfGenerated];
            Random rand = new Random();
            for (int i = 0; i < lenghtOfGenerated; i++)
            {
                int rand1 = Randomize(3, rand);
                if (rand1 == 0)
                {
                    int rand2 = Randomize(26, rand);
                    generated[i] = letters[rand2];
                }
                else if (rand1 == 1)
                {
                    int rand2 = Randomize(26, rand);
                    generated[i] = smallLetters[rand2];
                }
                else if (rand1 == 2)
                {
                    int rand2 = Randomize(10, rand);
                    generated[i] = numbers[rand2];
                }
            }
            string output = new string(generated);
            return output;
        }
        public static string OnlyText(int lenghtOfGenerated)
        {
            if (lenghtOfGenerated <= 0)
            {
                return "Incorrect values.";
            }
            char[] letters = InitializeLetters();
            char[] smallLetters = InitializeSmallLetters();
            char[] numbers = InitializeNumbers();
            char[] generated = new char[lenghtOfGenerated];
            Random rand = new Random();
            for (int i = 0; i < lenghtOfGenerated; i++)
            {
                int rand1 = Randomize(2, rand);
                if (rand1 == 0)
                {
                    int rand2 = Randomize(26, rand);
                    generated[i] = letters[rand2];
                }
                else if (rand1 == 1)
                {
                    int rand2 = Randomize(26, rand);
                    generated[i] = smallLetters[rand2];
                }
            }
            string output = new string(generated);
            return output;
        }
        public static string OnlyNumbers(int lenghtOfGenerated)
        {
            if (lenghtOfGenerated <= 0)
            {
                return "Incorrect values.";
            }
            Random rand = new Random();
            string output = null;
            for(int i = 0; i < lenghtOfGenerated; i++)
            {
                output = output + Convert.ToString(rand.Next(0, 9));
            }
            return output;
        }
        private static char[] InitializeLetters()
        {
            char[] letters = {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            return letters;
        }
        private static char[] InitializeSmallLetters()
        {
            char[] smallLetters = {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };
            return smallLetters;
        }
        private static char[] InitializeNumbers()
        {
            char[] numbers =
                {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            return numbers;
        }
        }
    }
