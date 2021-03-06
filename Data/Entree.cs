﻿/*
 * Author: Tayler Stoppel
 * Class: Entree.cs
 * Purpose: An entree class for the cowboy cafe project
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an entree.
    /// </summary>
    public abstract class Entree: IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the entree.
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets the calories of the entree.
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Special instructions for preparing the entree.
        /// </summary>
        public virtual List<string> SpecialInstructions { get; set; }
    }
}
