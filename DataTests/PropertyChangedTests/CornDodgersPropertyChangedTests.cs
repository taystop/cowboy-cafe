using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        // Test 1: Corn Dodgers should implement INotifyPropertyChanged
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
        }
        // Test 2: Changing Size should invoke propertychanged on Size
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSize()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Size", () =>
            {
                corn.Size = Size.Small;
            });
            Assert.PropertyChanged(corn, "Size", () =>
            {
                corn.Size = Size.Medium;
            });
            Assert.PropertyChanged(corn, "Size", () =>
            {
                corn.Size = Size.Large;
            });
        }
        // Test 3: Changing Size should invoke propertychanged on Price
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnPrice()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Price", () =>
            {
                corn.Size = Size.Small;
            });
            Assert.PropertyChanged(corn, "Price", () =>
            {
                corn.Size = Size.Medium;
            });
            Assert.PropertyChanged(corn, "Price", () =>
            {
                corn.Size = Size.Large;
            });
        }
        // Test 4: Changing Size should invoke propertychanged on Calories
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnCalories()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "Calories", () =>
            {
                corn.Size = Size.Small;
            });
            Assert.PropertyChanged(corn, "Calories", () =>
            {
                corn.Size = Size.Medium;
            });
            Assert.PropertyChanged(corn, "Calories", () =>
            {
                corn.Size = Size.Large;
            });
        }
        // Test 5: Changing Size should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSpecialInstructions()
        {
            var corn = new CornDodgers();
            Assert.PropertyChanged(corn, "SpecialInstructions", () =>
            {
                corn.Size = Size.Small;
            });
            Assert.PropertyChanged(corn, "SpecialInstructions", () =>
            {
                corn.Size = Size.Medium;
            });
            Assert.PropertyChanged(corn, "SpecialInstructions", () =>
            {
                corn.Size = Size.Large;
            });
        }
    }
}
