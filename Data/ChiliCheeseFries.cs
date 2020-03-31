﻿/*
 * Author: Tayler Stoppel
 * Class: ChiliCheeseFries.cs
 * Purpose: A side object class for the cowboy cafe project
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Cheese Fries side.
    /// </summary>
    public class ChiliCheeseFries: Side, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Size of the Fries
        /// </summary>
        private Size size = Size.Small;
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

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
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
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
                    case Size.Large :
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The size followed by "Chili Cheese Fries" as a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Chili Cheese Fries";
        }
    }
}
