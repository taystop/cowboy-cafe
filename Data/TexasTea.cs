/*
 * Author: Tayler Stoppel
 * Class: TexasTea.cs
 * Purpose: Class representing a texas tea object for a menu;
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The TexasTea drink class.
    /// </summary>
    public class TexasTea: Drink
    {
        /// <summary>
        /// If tea is sweet.
        /// </summary>
        private bool sweet = true;
        public bool Sweet
        {
            get => sweet;
            set
            {
                sweet = value;
            }
        }

        /// <summary>
        /// If the tea has ice in it.
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
        /// If the tea has lemon.
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
        /// The price of the tea.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.00;
                    case Size.Medium: return 1.50;
                    case Size.Large: return 2.00;
                    default: throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The number of calories in the tea.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (sweet)
                {
                    switch (Size)
                    {
                        case Size.Small: return 10;
                        case Size.Medium: return 22;
                        case Size.Large: return 36;
                        default: throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small: return 5;
                        case Size.Medium: return 11;
                        case Size.Large: return 18;
                        default: throw new NotImplementedException();
                    }
                }
            }
        }

        /// <summary>
        /// Special instructions for preparing the tea.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                    instructions.Add("Hold Ice");
                if (lemon)
                    instructions.Add("Add Lemon");
                if (!sweet)
                    instructions.Add("Make Unsweet Tea");
                return instructions;
            }
        }
    }
}
