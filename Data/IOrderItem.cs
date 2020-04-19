/*
 * Author: Tayler Stoppel
 * Class: IOrderItem.cs
 * Purpose: An interface for different types of items used in creating an order.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// Price of the item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Special instructions for the item.
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// Calories of the item.
        /// </summary>
        uint Calories { get; }
    }
}
