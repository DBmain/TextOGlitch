using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace TextGlitch
{
    public class Glitch
    {
        private static char[] unicodeSquares =
        {
            '\u0000', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\u0007', '\u0008', '\u0009', '\u000b', '\u000c', '\u000d', '\u000e', '\u000f',
            '\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017', '\u0018', '\u0019', '\u001a', '\u001b', '\u001c', '\u001d', '\u001e', '\u001f', '\u007f'
        };

        private static int randomize(int symbolsToGlitch2)
        {
            Random temp = new Random();
            while (true)
            {
                int rand;
                rand = temp.Next(0, symbolsToGlitch2 + 1);
                if (rand != 0)
                {
                    return rand;
                }
            }
        }
        private static string small(char[] text, int symbolsToGlitch, char[] smalls, char[] bigs, char[] numbers, int lenghtOutput, Random temp)
        {
            lenghtOutput = lenghtOutput - 2;
            int rand;
            for (int i = 0; i < symbolsToGlitch; i++)
            {
                Thread.Sleep(5);
                rand = temp.Next(0, 26);
                if (rand >= 0 && rand < 8)
                {
                    int rand2 = randomize(lenghtOutput);
                    text[rand2] = smalls[rand];
                }
                else if (rand > 8 && rand < 17)
                {
                    int rand2 = randomize(lenghtOutput);
                    text[rand2] = bigs[rand];
                }
                else
                {

                    int rand2 = randomize(lenghtOutput);
                    text[rand2] = bigs[rand];
                }
            }
            lenghtOutput = lenghtOutput + 2;
            string textOutput = new string(text);
            return textOutput;
        }
        private static char[] initializeLetters()
        {
            char[] letters = {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            return letters;
        }
        private static char[] initializeSmallLetters()
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
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
        private static string glitchProcess(string originalText, int glitchExtent)
        {
            char[] numbers = initializeNumbers();
            char[] smallCharacters = initializeSmallLetters();
            char[] bigCharacters = initializeLetters();
            byte[] str1Byte = System.Text.Encoding.UTF8.GetBytes(originalText);
            originalText = Convert.ToBase64String(str1Byte);
            char[] textCoded = originalText.ToCharArray();
            Random temp = new Random();
            string getGlitchedBase = null;
            byte[] convertBase;
            if (originalText.Length < 32)
            {
                getGlitchedBase = small(textCoded, (glitchExtent), smallCharacters, bigCharacters, numbers, textCoded.Length, temp);
                convertBase = Convert.FromBase64String(getGlitchedBase);
                return Encoding.UTF8.GetString(convertBase);
            }
            else
            {
                getGlitchedBase = small(textCoded, (originalText.Length / 32 * glitchExtent), smallCharacters, bigCharacters, numbers, textCoded.Length, temp);
                convertBase = Convert.FromBase64String(getGlitchedBase);
                return Encoding.UTF8.GetString(convertBase);
            }
            /*if (textCoded.Length <= 15) // Проверяем кол-во символов в Base64, выполняем рандом-замену оных и выводим на экран.
            {
                string getGlitchedBase = small(textCoded, (1 * glitchExtent), smallCharacters, bigCharacters, numbers, textCoded.Length, temp);
                byte[] convertBase = Convert.FromBase64String(getGlitchedBase);
                // string outText = Encoding.UTF8.GetString(convertBase);
                return Encoding.UTF8.GetString(convertBase);
            }

            else if (textCoded.Length <= 50)
            {
                string getGlitchedBase = small(textCoded, (2 * glitchExtent), smallCharacters, bigCharacters, numbers, textCoded.Length, temp);
                byte[] convertBase = Convert.FromBase64String(getGlitchedBase);
                return Encoding.UTF8.GetString(convertBase);
            }

            else if (textCoded.Length <= 100)
            {
                string getGlitchedBase = small(textCoded, (4 * glitchExtent), smallCharacters, bigCharacters, numbers, textCoded.Length, temp);
                byte[] convertBase = Convert.FromBase64String(getGlitchedBase);
                return Encoding.UTF8.GetString(convertBase);
            }

            else if (textCoded.Length <= 200)
            {
                string getGlitchedBase = small(textCoded, (8 * glitchExtent), smallCharacters, bigCharacters, numbers, textCoded.Length, temp);
                byte[] convertBase = Convert.FromBase64String(getGlitchedBase);
                return Encoding.UTF8.GetString(convertBase);
            }
            else if (textCoded.Length <= 400)
            {
                string getGlitchedBase = small(textCoded, (16 * glitchExtent), smallCharacters, bigCharacters, numbers, textCoded.Length, temp);
                byte[] convertBase = Convert.FromBase64String(getGlitchedBase);
                return Encoding.UTF8.GetString(convertBase);
            }
            else
            {
                string getGlitchedBase = small(textCoded, (25 * glitchExtent), smallCharacters, bigCharacters, numbers, textCoded.Length, temp);
                byte[] convertBase = Convert.FromBase64String(getGlitchedBase);
                return Encoding.UTF8.GetString(convertBase);
            }*/

        }
        public static string Text(string originalText, int glitchExtent, bool isItLight)
        {
            if (originalText == "")
            {
                return "Nothing to glitch.";
            }
            if (glitchExtent <= 0 || glitchExtent > originalText.Length)
            {
                return "Error in glitch extent.";
            }
            if (!isItLight) return glitchProcess(originalText, glitchExtent);
            else
            {
                char[] light = glitchProcess(originalText, glitchExtent).ToCharArray();
                int count = 0;
                foreach (char b in light)
                {
                    if (b == '�' || unicodeSquares.Contains(b))
                    {
                        count++;
                    }
                }
                char[] outputLight = new char[light.Length - count];
                int i = 0;
                foreach (char b in light)
                {
                    if (b != '�' && !unicodeSquares.Contains(b))
                    {
                        outputLight[i] = b;
                        i++;
                    }
                    else
                    {
                        continue;
                    }
                }
                return new string(outputLight);
            }
        }
    }
}
