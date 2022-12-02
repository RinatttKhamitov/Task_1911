using System;
using System.Collections.Generic;
using System.Text;

namespace Тумаков
{
    class ACipher : ICipher
    {
        private char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public string decode(string str)
        {
            string deStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                int index = Array.IndexOf(letters, str[i]);
                if (index == 0)
                {
                    deStr += letters[25];
                }
                else
                {
                    deStr += letters[index-1];
                }
            }
            return deStr;
        }

        public string encode(string str)
        {
            string deStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                int index = Array.IndexOf(letters, str[i]);
                if (index == 25)
                {
                    deStr += letters[0];
                }
                else
                {
                    deStr += letters[index + 1];
                }
            }
            return deStr;
        }
    }
}
