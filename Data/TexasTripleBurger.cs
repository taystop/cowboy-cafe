/*
 * Author: Tayler Stoppel
 * Class: TexasTripleBurger.cs
 * Purpose: An entree object class for the cowboy cafe project
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree.
    /// </summary>
    public class TexasTripleBurger: Entree
    {
        /// <summary>
        /// If the burger has a bun.
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// If the burger has ketchup.
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// If the burger has mustard.
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// If the burger has pickles.
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// If the burger has cheese.
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// If the burger has tomato.
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// If the burger has lettuce.
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// If the burger has mayo.
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// If the burger has bacon.
        /// </summary>
        private bool bacon = true;
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        /// <summary>
        /// If the burger has egg.
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// The price of the burger.
        /// </summary>
        public override double Price
        {
            get { return 6.45; }
        }

        /// <summary>
        /// The number of calories the burger has.
        /// </summary>
        public override uint Calories
        {
            get { return 698; }
        }

        /// <summary>
        /// Special instructions for preparing the burger.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");
                return instructions;
            }
        }
    }
}
