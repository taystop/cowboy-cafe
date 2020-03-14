/*
 * Author: Zombiepaladin
 * Edited By: Tayler Stoppel
 * Class: Side.cs
 * Purpose: A side class for the cowboy cafe project
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side: IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for preparing a side.
        /// </summary>
        public virtual List<string> SpecialInstructions { get; }
    }
}
