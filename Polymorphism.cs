using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    public class Polymorphism
    {
        public class MethodOverLoading
        {
            public int AddNums(int a, int b)
            {
                return a + b;
            }


            public double AddNums(double a, double b)
            {
                return a + b;
            }

            public string AddNums(string a, string b, string c)
            {
                return a + b + c;
            }
        }

    }
}
