/*
 * Author: Tayler Stoppel
 * Class: Water.cs
 * Purpose: A class representing a water drink.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The water drink class.
    /// </summary>
    public class Water: Drink
    {
        /// <summary>
        /// If the water has lemon.
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// If the water has lemon.
        /// </summary>
        private bool ice = true;
        public override bool Ice
        {
            get => ice;
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// The price of the water.
        /// </summary>
        public override double Price
        {
            get => 0.12;
        }

        /// <summary>
        /// The calories in the water.
        /// </summary>
        public override uint Calories
        {
            get => 0;
        }

        /// <summary>
        /// Special instructions for preparing water.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!ice)
                    instructions.Add("Hold Ice");
                if (lemon)
                    instructions.Add("Add Lemon");
                return instructions;
            }
        }
    }
}
