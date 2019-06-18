using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskingClasses
{
    public class Masker
    {
        public string MaskSecureNumbers(string input)
        {
            char[] chArr = input.ToCharArray();

            int index = (chArr.Length - 4);

            for(var x =0; x < index; x++)
            {
                chArr[x] = '#';
            }

            string secureStr = new string(chArr);

            return secureStr;
        }
    }
}
