using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class AngryChickenPropertyChangedTests
    {
        // Test 1: Angry Chicken should implement INotifyPropertyChanged
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        // Test 2: Changing Bread property invokes property changed for bread
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
            });
        }
        // Test 3: Changing Bread property invokes property changed for special instructions
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Bread = false;
            });
        }
        // Test 4: Changing Pickle property invokes property changed for pickle
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () =>
            {
                chicken.Pickle = false;
            });
        }
        // Test 5: Changing Pickle property invokes property changed for special instructions
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Pickle = false;
            });
        }
    }
}
