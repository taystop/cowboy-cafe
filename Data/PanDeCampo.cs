/*
 * Author: Tayler Stoppel
 * Class: PanDeCampo.cs
 * Purpose: A side object class for the cowboy cafe project
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the pan de campo side.
    /// </summary>
    public class PanDeCampo: Side, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Size of the PanDeCampo
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
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
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
            return Size.ToString() + " Pan de Campo";
        }
    }
}
