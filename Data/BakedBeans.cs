/*
 * Author: Tayler Stoppel
 * Class: BakedBeans.cs
 * Purpose: A side object class for the cowboy cafe project
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the baked beans side.
    /// </summary>
    public class BakedBeans: Side
    {
        /// <summary>
        /// The price of the side based on it's size.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
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
                switch (Size)
                {
                    case Size.Large:
                        return 410;
                    case Size.Medium:
                        return 378;
                    case Size.Small:
                        return 312;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
