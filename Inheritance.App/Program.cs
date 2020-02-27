using Inheritance.Entities;
using System;
using System.Collections.Generic;

namespace Inheritance.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Fido", "Gårdhund", 6, "A-1234");
            Dog dog2 = new Dog("Max", "Fårhund", 10, "G-7246");
            Dog dog3 = new Dog("Donut", "Corgi", 2, "K-1911");
            Cat cat1 = new Cat("Whiskers", "idk cat races", 5);
            Cat cat2 = new Cat("Pretzel", "still dont know", 7);
            Cat cat3 = new Cat("Cashew", "negative", 4);

            List<Pet> pets = new List<Pet>
            {
                dog1,
                dog2,
                dog3,
                cat1,
                cat2,
                cat3
            };

            foreach (Pet p in pets)
            {
                if (p is Cat)
                {
                    Console.WriteLine("Kat");
                    Cat c = p as Cat;
                    Console.WriteLine(c.ToString());
                    Console.WriteLine();
                    c.SaySomething();
                    c.ShedHair();
                    c.ScratchSofa();
                    Console.WriteLine();
                }
                else if (p is Dog)
                {
                    Console.WriteLine("Hund");
                    Dog d = p as Dog;
                    Console.WriteLine(d.ToString());
                    Console.WriteLine();
                    d.SaySomething();
                    d.ShedHair();
                    d.BitePostman();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("dunnolol");
                }
            }
        }
    }
}

