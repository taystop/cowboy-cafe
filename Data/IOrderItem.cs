/*
 * Author: Tayler Stoppel
 * Class: IOrderItem.cs
 * Purpose: An interface for different types of items used in creating an order.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// Price of the item.
        /// </summary>
        abstract double Price { get; }

        /// <summary>
        /// Special instructions for the item.
        /// </summary>
        abstract List<string> SpecialInstructions { get; }
    }
}
