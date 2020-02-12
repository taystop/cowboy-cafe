/*
 * Author: Tayler Stoppel
 * Class: CowboyCoffee.cs
 * Purpose: A class representing a cowboy coffee drink.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The cowboy coffee drink class.
    /// </summary>
    public class CowboyCoffee: Drink
    {
        /// <summary>
        /// If there should be room for cream.
        /// </summary>
        private bool roomforcream = false;
        public bool RoomForCream { 
            get => roomforcream; 
            set { roomforcream = value; } 
        }

        /// <summary>
        /// If the coffee should be decaf
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
            }
        }

        /// <summary>
        /// If Ice should be added.
        /// </summary>
        private bool ice = false;
        public override bool Ice
        {
            get => ice;
            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// The price of the Coffee.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small: return 0.60;
                    case Size.Medium: return 1.10;
                    case Size.Large: return 1.60;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The number of calories in the coffee.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 3;
                    case Size.Medium: return 5;
                    case Size.Large: return 7;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Special instructions for preparing the coffee.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (roomforcream)
                    instructions.Add("Room for Cream");
                if (ice)
                    instructions.Add("Add Ice");
                if (decaf)
                    instructions.Add("Decaf Coffee");
                return instructions;
            }
        }
    }
}
