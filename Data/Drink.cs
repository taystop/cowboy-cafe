/* 
 * Author: Tayler Stoppel
 * Class: Drink.cs
 * Purpose: An abstract base class for all drinks
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The base class for all drinks.
    /// </summary>
    public abstract class Drink: IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;
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

        /// <summary>
        /// Special instructions for a drink.
        /// </summary>
        public virtual List<string> SpecialInstructions { get; set; }
    }
}
