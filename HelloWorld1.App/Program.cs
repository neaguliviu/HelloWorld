﻿using HelloWorld1.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeter = new Greeter();
            var greeting = greeter.GetGreeting("Liviu");
            Console.WriteLine(greeting);

        }
    }
}