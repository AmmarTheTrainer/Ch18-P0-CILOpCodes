﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch18_P0_CILOpCodes
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public void PrintMessage()
        {
            string myMessage = "Hello.";
            Console.WriteLine(myMessage);
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
