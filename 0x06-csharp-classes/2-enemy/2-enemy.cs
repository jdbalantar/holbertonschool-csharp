using System;
namespace Enemies
{
    /// <summary> Empty Class Zombie </summary>
    public class Zombie
    {
        /// <summary>
        /// Constructor of Zombie class
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// public constructor with int parameter
        /// </summary>
        /// <param name="value">parameter of Zombie class</param>

        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }

        /// <summary>
        /// public int health, no have any value
        /// </summary>
        public int health;
    }
}
