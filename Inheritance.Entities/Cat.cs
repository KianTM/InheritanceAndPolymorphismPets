using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Entities
{
    /// <summary>
    /// An object instance of class Cat.
    /// </summary>
    public class Cat : Pet
    {
        /// <summary>
        /// Instantiates an object of class Cat.
        /// </summary>
        /// <param name="name">The cat's name.</param>
        /// <param name="race">The cat's race.</param>
        /// <param name="age">The cat's age.</param>
        public Cat(string name, string race, int age) : base(name, race, age) { }

        /// <summary>
        /// Prints a message to the console, representing the cat saying something.
        /// </summary>
        public override void SaySomething() => Console.WriteLine("Miav.");
        /// <summary>
        /// Prints a message to the console, exclaiming that the cat just scratched the sofa.
        /// </summary>
        public void ScratchSofa() => Console.WriteLine("Katten kradser sofaen.");
    }
}
