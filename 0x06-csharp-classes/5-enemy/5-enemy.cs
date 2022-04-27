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
        /// private int health, no have any value
        /// </summary>
        private int health;
        /// <summary>
        /// Method that returns health
        /// </summary>
        public int GetHealth()
        {
            return health;
        }
        /// <summary>
        /// private string, default value is (No name)
        /// </summary>
        private string name = "(No name)";
        /// <summary>
        /// String propertie for set or get value
        /// </summary>
        /// <value>parameter to set in name</value>
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
