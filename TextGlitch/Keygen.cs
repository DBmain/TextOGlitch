using System;
using System.Threading;

namespace TextGlitch
{
    public class Keygen
    {
        private static int randomizeKey(int a, int b, Random tempRand)
        {
            int tempRand2;
            tempRand2 = tempRand.Next(a, b);
            return tempRand2;
        }
        private static char[] initializeLetters()
        {
            char[] letters = {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            return letters;
        }
        private static char[] initializeNumbers()
        {
            char[] numbers =
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            return numbers;
        }
        public static string Create(int symbolsValue, int blocksValue)
        {
            Thread.Sleep(20);
            if (symbolsValue <= 0 || blocksValue <= 0)
            {
                return "Incorrect values.";
            }
            string keyReady;
            char[] letters = initializeLetters();
            char[] numbers = initializeNumbers();
            char[] key = new char[(symbolsValue * blocksValue) + blocksValue - 1];
            int keyCount = 0;
            int i;
            int lenghtKey = key.Length - 1;
            Random tempRand = new Random();
            for (int c = 0; c < blocksValue; c++)
            {
                for (i = 0; i < symbolsValue; i++)
                {
                    bool keyOrNumber = Convert.ToBoolean(randomizeKey(0, 2, tempRand));
                    if (keyOrNumber)
                    {
                        key[keyCount] = letters[randomizeKey(0, 26, tempRand)];
                        keyCount++;
                    }
                    else if (!keyOrNumber)
                    {
                        key[keyCount] = numbers[randomizeKey(0, 10, tempRand)];
                        keyCount++;
                    }
                    if (keyCount == lenghtKey + 1)
                    {
                        keyReady = new string(key);
                        return keyReady;
                    }
                }
                key[keyCount] = '-';
                keyCount++;
            }
            return null;
        }
    }
}
