using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Entities
{
    /// <summary>
    /// Object instance of class Dog.
    /// </summary>
    public class Dog : Pet
    {
        /// <summary>
        /// The dog's dog tag.
        /// </summary>
        private string dogTag;

        /// <summary>
        /// Instantiates an object of the class Dog.
        /// </summary>
        /// <param name="name">The dog's name.</param>
        /// <param name="race">The dog's race.</param>
        /// <param name="age">The dog's age.</param>
        /// <param name="dogTag">The dog's dog tag.</param>
        public Dog(string name, string race, int age, string dogTag) : base(name, race, age)
        {
            this.dogTag = dogTag;
        }

        /// <summary>
        /// Prints a message to the console, representing the dog saying something.
        /// </summary>
        public override void SaySomething() => Console.WriteLine("Vuf.");
        /// <summary>
        /// Prints a message to the console, exclaiming that the dog just bit a postman.
        /// </summary>
        public void BitePostman() => Console.WriteLine("Hunden bider postbuddet.");
        public override string ToString() =>
            base.ToString() +
            $"\nHundetegn: {this.dogTag}";
    }
}
