﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM91U5.Load_File
{
    internal class Parser
    {
        public Work Parse(string[] columns)
        {
            return new Work(columns[0], int.Parse(columns[1]), int.Parse(columns[2]));
        }
    }
}
