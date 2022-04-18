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


            public virtual void SayMyName()
            {
                Console.WriteLine("My name is Victor");
            }
        }


        public class MethodOverridding : MethodOverLoading
        {
            public override void SayMyName()
            {
                Console.WriteLine("My name is James");
            }

        }

    }
}
