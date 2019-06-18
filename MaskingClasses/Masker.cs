using System;

namespace MaskingClasses
{
    public class Masker
    {
        public string MaskSecureNumbers(string input)
        {
            char[] chArr = input.ToCharArray();

            if (chArr.Length <= 4) return String.Empty;

            int stopIndex = (chArr.Length - 4);

            for(var x =0; x < stopIndex; x++)
            {
                chArr[x] = '#';
            }

            string secureStr = new string(chArr);

            return secureStr;
        }
    }
}
