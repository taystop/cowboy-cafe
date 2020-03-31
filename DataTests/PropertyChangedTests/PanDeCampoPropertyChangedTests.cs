using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        // Test 1: Pan De Campo should implement INotifyPropertyChanged
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var campo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(campo);
        }
        // Test 2: Changing Size should invoke propertychanged on Size
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Small;
            });
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Medium;
            });
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Large;
            });
        }
        // Test 3: Changing Size should invoke propertychanged on Price
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnPrice()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Small;
            });
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Medium;
            });
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Large;
            });
        }
        // Test 4: Changing Size should invoke propertychanged on Calories
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnCalories()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Small;
            });
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Medium;
            });
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Large;
            });
        }
        // Test 5: Changing Size should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSpecialInstructions()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "SpecialInstructions", () =>
            {
                campo.Size = Size.Small;
            });
            Assert.PropertyChanged(campo, "SpecialInstructions", () =>
            {
                campo.Size = Size.Medium;
            });
            Assert.PropertyChanged(campo, "SpecialInstructions", () =>
            {
                campo.Size = Size.Large;
            });
        }
    }
}
