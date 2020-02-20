/*
 * Author: Tayler Stoppel
 * Class: CornDodgers.cs
 * Purpose: A side object class for the cowboy cafe project
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Corn Dodgers side.
    /// </summary>
    public class CornDodgers: Side
    {
        /// <summary>
        /// The price of the side based on it's size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The number of calories for this side.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Large:
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Converts object to a string
        /// </summary>
        /// <returns>Size as a string and the type of side</returns>
        public override string ToString()
        {
            return Size.ToString() + " Corn Dodgers";
        }
    }
}
