﻿using System;
using System.Collections.Generic;
using System.Text;

namespace git_test
{
    class NewClass
    {
        public void PrintHello()
        {
            Console.WriteLine($"Hello {SetCountry()}}");
        }

        private string SetCountry(){
            return USA;
        }
    }
}
