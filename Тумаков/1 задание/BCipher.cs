using System;
using System.Collections.Generic;
using System.Text;

namespace Тумаков
{
    class BCipher
    {
        private char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray(); //26

        public string decode(string str, int num)
        {
            string deStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                int index = Array.IndexOf(letters, str[i]);
                int k = 0;
                while ((index - num + k * 26) < 26)
                {
                    k++;
                }
                deStr += letters[index - num + (k - 1) * 26];

            }
            return deStr;
        }

        public string encode(string str, int num)
        {
            string deStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                int index = Array.IndexOf(letters, str[i]);
                int k = 0;
                while ((index + num + k * 26) < 26)
                {
                    k++;
                }
                deStr += letters[index + num + (k - 1) * 26];
            }
            return deStr;
        }
    }
}
