using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class OrderPropertyChangedTests
    {
        // Test 1: Order should implement INotifyPropertyChanged
        [Fact]
        public void OrderShouldImplementINotifyPropertyChanged()
        {
            var or = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(or);
        }
        // Test 2: Adding item invokes propertychanged on Items
        [Fact]
        public void AddingItemInvokesPropertyChangedOnItems()
        {
            var or = new Order();
            var item = new AngryChicken();
            Assert.PropertyChanged(or, "Items", () =>
            {
                or.Add(item);
            });
        }
        // Test 3: Adding item invokes propertychanged on Subtotal
        [Fact]
        public void AddingItemInvokesPropertyChangedOnSubtotal()
        {
            var or = new Order();
            var item = new AngryChicken();
            Assert.PropertyChanged(or, "Subtotal", () =>
            {
                or.Add(item);
            });
        }
        // Test 4: Adding item invokes propertychanged on Price
        [Fact]
        public void AddingItemInvokesPropertyChangedOnPrice()
        {
            var or = new Order();
            var item = new AngryChicken();
            Assert.PropertyChanged(or, "Price", () =>
            {
                or.Add(item);
            });
        }
        // Test 2: Removing item invokes propertychanged on Items
        [Fact]
        public void RemovingItemInvokesPropertyChangedOnItems()
        {
            var or = new Order();
            var item = new AngryChicken();
            or.Add(item);
            Assert.PropertyChanged(or, "Items", () =>
            {
                or.Remove(item);
            });
        }
        // Test 3: Removing item invokes propertychanged on Subtotal
        [Fact]
        public void RemovingItemInvokesPropertyChangedOnSubtotal()
        {
            var or = new Order();
            var item = new AngryChicken();
            or.Add(item);
            Assert.PropertyChanged(or, "Subtotal", () =>
            {
                or.Remove(item);
            });
        }
        // Test 4: Removing item invokes propertychanged on Price
        [Fact]
        public void RemovingItemInvokesPropertyChangedOnPrice()
        {
            var or = new Order();
            var item = new AngryChicken();
            or.Add(item);
            Assert.PropertyChanged(or, "Price", () =>
            {
                or.Remove(item);
            });
        }
    }
}
