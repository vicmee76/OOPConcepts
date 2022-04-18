using System;
using static OOPConcepts.Abstractions;
using static OOPConcepts.Inheritance;
using static OOPConcepts.Polymorphism;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            Father father = new Father();
            father.FatherHairColor();
            Son son = new Son();
            son.FatherHairColor();
            son.SonHairColor();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Encapsulation");
            Encapsulation enp = new Encapsulation();
            enp.sayName();
            Console.WriteLine(enp.sayAge);
            Console.WriteLine(enp.sayGender);


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Polymorphism - Method Overloading");
            MethodOverLoading load = new MethodOverLoading();
            Console.WriteLine(load.AddNums(908, 6876));
            Console.WriteLine(load.AddNums(5.2, 6.5));
            Console.WriteLine(load.AddNums("My", "Name", "Is"));

            Console.WriteLine("Polymorphism - Method Overidding");
            MethodOverridding over = new MethodOverridding(); 
            load.SayMyName();
            over.SayMyName();


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Abstraction");
            Toyota t = new Toyota();
            Console.WriteLine(t.CarColor());
            Console.WriteLine(t.SeatNumber());

        }
    }
}
