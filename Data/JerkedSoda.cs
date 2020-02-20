/* 
 * Author: Tayler Stoppel
 * Class: JerkedSoda.cs
 * Purpose: A class representing a jerked soda beverage.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The jerked soda class.
    /// </summary>
    public class JerkedSoda: Drink
    {
        /// <summary>
        /// The flavor of the soda.
        /// </summary>
        public SodaFlavor Flavor { get; set; }
        
        /// <summary>
        /// If the soda has ice in it.
        /// </summary>
        private bool ice = true;
        public override bool Ice
        {
            get => ice;
            set { ice = value; }
        }

        /// <summary>
        /// The price of the soda based on size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.59;
                    case Size.Medium: return 2.10;
                    case Size.Large: return 2.59;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The number of calories in the soda based on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small: return 110;
                    case Size.Medium: return 146;
                    case Size.Large: return 198;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Special instructions for making a jerked soda beverage.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                    instructions.Add("Hold Ice");
                return instructions;
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>A string containing the size and flavor of the soda.</returns>
        public override string ToString()
        {
            string over = Size.ToString();
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    over += " Birch Beer";
                    break;
                case SodaFlavor.CreamSoda:
                    over += " Cream Soda";
                    break;
                case SodaFlavor.OrangeSoda:
                    over += " Orange Soda";
                    break;
                case SodaFlavor.RootBeer:
                    over += " Root Beer";
                    break;
                case SodaFlavor.Sarsparilla:
                    over += " Sarsparilla";
                    break;
            }
            over += " Jerked Soda";
            return over;
        }
    }
}
