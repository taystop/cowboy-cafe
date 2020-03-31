/*
 * Author: Tayler Stoppel
 * Class: CowboyCoffee.cs
 * Purpose: A class representing a cowboy coffee drink.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The cowboy coffee drink class.
    /// </summary>
    public class CowboyCoffee: Drink, INotifyPropertyChanged
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// If there should be room for cream.
        /// </summary>
        private bool roomforcream = false;
        public bool RoomForCream { 
            get => roomforcream; 
            set 
            { 
                roomforcream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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

        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <returns>The size of coffee and if it's decaf as a string</returns>
        public override string ToString()
        {
            string over = Size.ToString();
            if (decaf)
                over += " Decaf";
            over += " Cowboy Coffee";
            return over;
        }
    }
}
