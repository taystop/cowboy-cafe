/*
 * Author: Tayler Stoppel
 * Class: Water.cs
 * Purpose: A class representing a water drink.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The water drink class.
    /// </summary>
    public class Water: Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// The Size of the Water
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
        /// If the water has lemon.
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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

        /// <summary>
        /// Convert the object to a string
        /// </summary>
        /// <returns>A string with the size of the water</returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
