using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        // Test 1: Dakota Double should implement INotifyPropertyChanged
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var burger = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }
        // Test 2: Changing Bun should invoke propertychanged for Bun
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Bun", () =>
            {
                burger.Bun = false;
            });
        }
        // Test 3: Changing Bun should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Bun = false;
            });
        }
        // Test 4: Changing Ketchup should invoke propertychanged for Ketchup
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Ketchup", () =>
            {
                burger.Ketchup = false;
            });
        }
        // Test 5: Changing Ketchup should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Ketchup = false;
            });
        }
        // Test 6: Changing Mustard should invoke propertychanged for Mustard
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Mustard", () =>
            {
                burger.Mustard = false;
            });
        }
        // Test 7: Changing Mustard should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mustard = false;
            });
        }
        // Test 8: Changing Pickle should invoke propertychanged for Pickle
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Pickle", () =>
            {
                burger.Pickle = false;
            });
        }
        // Test 9: Changing Pickle should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Pickle = false;
            });
        }
        // Test 10: Changing Cheese should invoke propertychanged for Cheese
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Cheese", () =>
            {
                burger.Cheese = false;
            });
        }
        // Test 11: Changing Cheese should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Cheese = false;
            });
        }
        // Test 12: Changing Tomato should invoke propertychanged for Tomato
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Tomato", () =>
            {
                burger.Tomato = false;
            });
        }
        // Test 13: Changing Tomato should invoke propertychanged for Special Instructions
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Tomato = false;
            });
        }
        // Test 14: Changing Lettuce should invoke propertychanged for Lettuce
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Lettuce", () =>
            {
                burger.Lettuce = false;
            });
        }
        // Test 15: Changing Lettuce should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Lettuce = false;
            });
        }
        // Test 16: Changing Mayo should invoke propertychanged for Mayo
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "Mayo", () =>
            {
                burger.Mayo = false;
            });
        }
        // Test 17: Changing Mayo should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var burger = new DakotaDoubleBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () =>
            {
                burger.Mayo = false;
            });
        }
    }
}
