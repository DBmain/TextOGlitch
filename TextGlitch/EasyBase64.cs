using System;
using System.Text;

namespace TextGlitch {
    public class EasyBase64
    {
        public static string Encode(string originalText)
        {
            byte[] str1Byte = System.Text.Encoding.UTF8.GetBytes(originalText);
            originalText = Convert.ToBase64String(str1Byte);
            return originalText;
        }
        public static string Decode(string originalText)
        {
            try
            {
                byte[] convertBase = Convert.FromBase64String(originalText);
                string outText = Encoding.UTF8.GetString(convertBase);
                return outText;
            }
            catch (FormatException)
            {
                return "It is not Base64.";
            }
        }
    }
}
