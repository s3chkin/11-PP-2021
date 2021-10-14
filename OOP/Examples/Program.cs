﻿using System;
using System.Linq;

namespace Examples
{
    class Program
    {
        static void Main()
        {
            var tc = new TestClass("ch88423423");
            Console.WriteLine(tc.Name);
            tc.Name = "ff8f"; //Chubaka -> Ch...
            Console.WriteLine(tc.Name);
            tc.Name = "ch"; //Chubaka -> Ch...
            Console.WriteLine(tc.Name);
            tc.Name = "c"; //Chubaka -> Ch...
            Console.WriteLine(tc.Name);
        }
    }

    class TestClass
    {
        //public string Name { get; set; }
        public TestClass(string name)
        {
            this.name = name;
        }

        private string name;
        public string Name
        {
            get
            {
                return string.Join("", name.Take(2)) + "...";
            }
            set
            {
                if ("0123456789&*^#@".Any(x => value.Contains(x)))
                {
                    Console.WriteLine("Invalid name, can not contain unsupported characters");
                    return;
                }
                if (value.Length < 2)
                {
                    Console.WriteLine("Invalid name, must be longer than 2 letters");
                    return;
                }
                name = value;                
            }
        }
    }
}