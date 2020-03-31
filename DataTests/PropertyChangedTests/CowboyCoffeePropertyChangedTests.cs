using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        // Test 1: Cowboy Coffee should implement INotifyPropertyChanged
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }
        // Test 2: Changing Size should invoke propertychanged on Size
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSize()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Small;
            });
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Size", () =>
            {
                coffee.Size = Size.Large;
            });
        }
        // Test 3: Changing Size should invoke propertychanged on Price
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnPrice()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Small;
            });
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Price", () =>
            {
                coffee.Size = Size.Large;
            });
        }
        // Test 4: Changing Size should invoke propertychanged on Calories
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnCalories()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Small;
            });
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "Calories", () =>
            {
                coffee.Size = Size.Large;
            });
        }
        // Test 5: Changing Size should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Size = Size.Small;
            });
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Size = Size.Medium;
            });
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Size = Size.Large;
            });
        }
        // Test 6: Changing RoomForCream should invoke propertychanged for RoomForCream
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = true;
            });
        }
        // Test 7: Changing RoomForCream should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = true;
            });
        }
        // Test 8: Changing Decaf should invoke propertychanged for Decaf
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = true;
            });
        }
        // Test 9: Changing Decaf should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = true;
            });
        }
        // Test 10: Changing Ice should invoke propertychanged for Ice
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = true;
            });
        }
        // Test 11: Changing Ice should invoke propertychanged for SpecialInstructions
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = true;
            });
        }
    }
}
