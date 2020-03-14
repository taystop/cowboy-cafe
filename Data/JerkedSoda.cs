/* 
 * Author: Tayler Stoppel
 * Class: JerkedSoda.cs
 * Purpose: A class representing a jerked soda beverage.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The jerked soda class.
    /// </summary>
    public class JerkedSoda: Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Size of the Jerked Soda
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
            }
        }

        /// <summary>
        /// The flavor of the soda.
        /// </summary>
        private SodaFlavor flavor;
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        
        /// <summary>
        /// If the soda has ice in it.
        /// </summary>
        private bool ice = true;
        public override bool Ice
        {
            get => ice;
            set 
            { 
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
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
