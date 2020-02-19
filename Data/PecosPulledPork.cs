﻿/*
 * Author: Tayler Stoppel
 * Class: PecosPulledPork.cs
 * Purpose: An entree object class for the cowboy cafe project
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree.
    /// </summary>
    public class PecosPulledPork: Entree
    {
        /// <summary>
        /// If the pork has bread.
        /// </summary>
        private bool bread = true;
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// If the pork has pickles.
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// The price of the pork.
        /// </summary>
        public override double Price
        {
            get { return 5.88; }
        }

        /// <summary>
        /// The number of calories in the pork.
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }

        /// <summary>
        /// Special instructions for preparing the pork.
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
        /// <returns>The string "Pecos Pulled Pork"</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
