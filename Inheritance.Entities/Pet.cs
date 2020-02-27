using System;

namespace Inheritance.Entities
{
    /// <summary>
    /// Abstract class Pet to be inherited from.
    /// </summary>
    public abstract class Pet
    {
        /// <summary>
        /// The pet's name.
        /// </summary>
        protected string name;
        /// <summary>
        /// The pet's race.
        /// </summary>
        protected string race;
        /// <summary>
        /// The pet's age.
        /// </summary>
        protected int age;

        /// <summary>
        /// Base constructor for class Pet.
        /// </summary>
        /// <param name="name">
        /// The pet's name.
        /// </param>
        /// <param name="race">
        /// The pet's race.
        /// </param>
        /// <param name="age">
        /// The pet's age.
        /// </param>
        public Pet(string name, string race, int age)
        {
            this.name = name;
            this.race = race;
            this.age = age;
        }

        /// <summary>
        /// Gets the pet's age as an int.
        /// </summary>
        /// <returns>
        /// The pet's age.
        /// </returns>
        public int GetAge() => age;
        /// <summary>
        /// Display's a message in chat, exclaiming that the pet has just shed some hair on the console.
        /// </summary>
        public void ShedHair() => Console.WriteLine("*der fældes hår på konsollen*");
        /// <summary>
        /// Abstract class that makes the pet say something. To be overwritten in derived classes.
        /// </summary>
        public abstract void SaySomething();
        public override string ToString() =>
            $"\n{this.name}" +
            $"\n{this.race}" +
            $"\n{this.age} år gammel";
    }
}
