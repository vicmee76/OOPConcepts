using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    public class Inheritance
    {
        public class Father
        {
            public void FatherHairColor()
            {
                Console.WriteLine("Fathers hair color is black");
            }
        }


        public class Son : Father
        {
            public void SonHairColor()
            {
                Console.WriteLine("Son's hair color is also black.");
            }
        }
    }
}
