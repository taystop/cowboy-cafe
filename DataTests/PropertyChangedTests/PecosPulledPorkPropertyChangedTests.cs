using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        // Test 1: Pecos Pulled Pork should implement INotifyPropertyChanged
        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }
        // Test 2: Changing Bread property invokes property changed for bread
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
            {
                pork.Bread = false;
            });
        }
        // Test 3: Changing Bread property invokes property changed for special instructions
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = false;
            });
        }
        // Test 4: Changing Pickle property invokes property changed for pickle
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = false;
            });
        }
        // Test 5: Changing Pickle property invokes property changed for special instructions
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = false;
            });
        }
    }
}
