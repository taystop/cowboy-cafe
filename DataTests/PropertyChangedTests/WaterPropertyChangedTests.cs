using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        // Test 1: Water should implement INotifyPropertyChanged
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var wa = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(wa);
        }
        // Test 2: Changing Size should invoke propertychanged on Size
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSize()
        {
            var wa = new Water();
            Assert.PropertyChanged(wa, "Size", () =>
            {
                wa.Size = Size.Small;
            });
            Assert.PropertyChanged(wa, "Size", () =>
            {
                wa.Size = Size.Medium;
            });
            Assert.PropertyChanged(wa, "Size", () =>
            {
                wa.Size = Size.Large;
            });
        }
        // Test 3: Changing Size should invoke propertychanged on Price
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnPrice()
        {
            var wa = new Water();
            Assert.PropertyChanged(wa, "Price", () =>
            {
                wa.Size = Size.Small;
            });
            Assert.PropertyChanged(wa, "Price", () =>
            {
                wa.Size = Size.Medium;
            });
            Assert.PropertyChanged(wa, "Price", () =>
            {
                wa.Size = Size.Large;
            });
        }
        // Test 4: Changing Size should invoke propertychanged on Calories
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnCalories()
        {
            var wa = new Water();
            Assert.PropertyChanged(wa, "Calories", () =>
            {
                wa.Size = Size.Small;
            });
            Assert.PropertyChanged(wa, "Calories", () =>
            {
                wa.Size = Size.Medium;
            });
            Assert.PropertyChanged(wa, "Calories", () =>
            {
                wa.Size = Size.Large;
            });
        }
        // Test 5: Changing Size should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSpecialInstructions()
        {
            var wa = new Water();
            Assert.PropertyChanged(wa, "SpecialInstructions", () =>
            {
                wa.Size = Size.Small;
            });
            Assert.PropertyChanged(wa, "SpecialInstructions", () =>
            {
                wa.Size = Size.Medium;
            });
            Assert.PropertyChanged(wa, "SpecialInstructions", () =>
            {
                wa.Size = Size.Large;
            });
        }
        
        // Test 6: Changing Ice should invoke propertychanged on Ice
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedOnIce()
        {
            var wa = new Water();
            Assert.PropertyChanged(wa, "Ice", () =>
            {
                wa.Ice = false;
            });
        }
        // Test 7: Changing Ice should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedOnSpecialInstructions()
        {
            var wa = new Water();
            Assert.PropertyChanged(wa, "SpecialInstructions", () =>
            {
                wa.Ice = false;
            });
        }
        // Test 8: Changing Lemon should invoke propertychanged on Lemon
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedOnLemon()
        {
            var wa = new Water();
            Assert.PropertyChanged(wa, "Lemon", () =>
            {
                wa.Lemon = true;
            });
        }
        // Test 9: Changing Lemon should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedOnSpecialInstuctions()
        {
            var wa = new Water();
            Assert.PropertyChanged(wa, "SpecialInstructions", () =>
            {
                wa.Lemon = true;
            });
        }
    }
}
