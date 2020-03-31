using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        // Test 1: Chili Cheese Fries should implement INotifyPropertyChanged
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var chili = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }
        // Test 2: Changing Size should invoke propertychanged on Size
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSize()
        {
            var chili = new ChiliCheeseFries();
            Assert.PropertyChanged(chili, "Size", () =>
            {
                chili.Size = Size.Small;
            });
            Assert.PropertyChanged(chili, "Size", () =>
            {
                chili.Size = Size.Medium;
            });
            Assert.PropertyChanged(chili, "Size", () =>
            {
                chili.Size = Size.Large;
            });
        }
        // Test 3: Changing Size should invoke propertychanged on Price
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnPrice()
        {
            var chili = new ChiliCheeseFries();
            Assert.PropertyChanged(chili, "Price", () =>
            {
                chili.Size = Size.Small;
            });
            Assert.PropertyChanged(chili, "Price", () =>
            {
                chili.Size = Size.Medium;
            });
            Assert.PropertyChanged(chili, "Price", () =>
            {
                chili.Size = Size.Large;
            });
        }
        // Test 4: Changing Size should invoke propertychanged on Calories
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnCalories()
        {
            var chili = new ChiliCheeseFries();
            Assert.PropertyChanged(chili, "Calories", () =>
            {
                chili.Size = Size.Small;
            });
            Assert.PropertyChanged(chili, "Calories", () =>
            {
                chili.Size = Size.Medium;
            });
            Assert.PropertyChanged(chili, "Calories", () =>
            {
                chili.Size = Size.Large;
            });
        }
        // Test 5: Changing Size should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSpecialInstructions()
        {
            var chili = new ChiliCheeseFries();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Size = Size.Small;
            });
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Size = Size.Medium;
            });
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Size = Size.Large;
            });
        }
    }
}
