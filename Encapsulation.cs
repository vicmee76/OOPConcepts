using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConcepts
{
    public class Encapsulation
    {
        public string name = "Victor";
        private int age = 27;
        protected string gender = "Male";


        public void sayName()
        {
            Console.WriteLine("My name is " + name);
        }

        public int sayAge
        {
            get { return age; }
            set { age = value; }
        }

        public string sayGender
        {
            get { return gender; }
            set { gender = value; }
        }
    }

}
