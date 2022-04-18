using System;
using static OOPConcepts.Inheritance;
using static OOPConcepts.Polymorphism;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Father father = new Father();
            father.FatherHairColor();
            Son son = new Son();
            son.FatherHairColor();
            son.SonHairColor();

            Console.WriteLine("");

            Encapsulation enp = new Encapsulation();
            enp.sayName();
            Console.WriteLine(enp.sayAge);
            Console.WriteLine(enp.sayGender);


            MethodOverLoading load = new MethodOverLoading();
            Console.WriteLine(load.AddNums(908, 6876));
            Console.WriteLine(load.AddNums(5.2, 6.5));
            Console.WriteLine(load.AddNums("My", "Name", "Is"));
            load.SayMyName();

            MethodOverridding over = new MethodOverridding();
            over.SayMyName();


        }
    }
}
