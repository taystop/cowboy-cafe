using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs: Entree
    {
        /// <summary>
        /// The price of the ribs.
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.5;
            }
        }

        /// <summary>
        /// The number of calories in the ribs.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// A list containing all special instructions for the ribs.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
    }
}
