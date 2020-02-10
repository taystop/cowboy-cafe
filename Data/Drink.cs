/* 
 * Author: Tayler Stoppel
 * Class: Drink.cs
 * Purpose: An abstract base class for all drinks
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The base class for all drinks.
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Price of the Drink.
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Calories of the Drink.
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Ingredients in the Drink.
        /// </summary>
        public virtual List<string> Ingredients { get; set; }

        /// <summary>
        /// Size of the Drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// If Drink has ice.
        /// </summary>
        public virtual bool Ice { get; set; }
    }
}
