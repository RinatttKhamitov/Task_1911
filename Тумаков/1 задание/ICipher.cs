using System;
using System.Collections.Generic;
using System.Text;

namespace Тумаков
{
    interface ICipher
    {
        public string encode(string str);
        public string decode(string str);
    }
}
