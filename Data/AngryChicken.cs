/* 
 * Author: Tayler Stoppel
 * Class: AngryChicken.cs
 * Purpose: An entree object for the cowboy cafe project.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken: Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// If the chicken is served with bread.
        /// </summary>
        private bool bread = true;
        public bool Bread
        {
            get { return bread; }
            set 
            {
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// If the chicken is served with pickles.
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get { return pickle; }
            set 
            { 
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// price of the Chicken.
        /// </summary>
        public override double Price { get => 5.99; }

        /// <summary>
        /// Calories in the chicken.
        /// </summary>
        public override uint Calories
        {
            get { return 190; }
        }

        /// <summary>
        /// Special instructions for preparing the chicken.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");
                return instructions;
            }
        }

        /// <summary>
        /// Converts The object to a string
        /// </summary>
        /// <returns>The string "Angry Chicken"</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
