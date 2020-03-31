using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        // Test 1: Jerked Soda should implement INotifyPropertyChanged
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }
        // Test 2: Changing Size should invoke propertychanged on Size
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Small;
            });
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Large;
            });
        }
        // Test 3: Changing Size should invoke propertychanged on Price
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Small;
            });
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = Size.Large;
            });
        }
        // Test 4: Changing Size should invoke propertychanged on Calories
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Small;
            });
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = Size.Large;
            });
        }
        // Test 5: Changing Size should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Size = Size.Small;
            });
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Size = Size.Medium;
            });
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Size = Size.Large;
            });
        }
        // Test 6: Changing Flavor should invoke propertychanged on Flavor
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedOnFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.BirchBeer;
            });
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            });
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.OrangeSoda;
            });
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.RootBeer;
            });
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            });
        }
        // Test 7: Changing Flavor should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedOnSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Flavor = SodaFlavor.BirchBeer;
            });
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            });
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Flavor = SodaFlavor.OrangeSoda;
            });
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Flavor = SodaFlavor.RootBeer;
            });
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Flavor = SodaFlavor.Sarsparilla;
            });
        }
        // Test 8: Changing Ice should invoke propertychanged on Ice
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedOnIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }
        // Test 9: Changing Ice should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedOnSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }
    }
}
