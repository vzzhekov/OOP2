﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Common
{
    public static class StringWordCount
    {
        public static string[] WordCount(this string str) {
                    return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
    }
    }
}
