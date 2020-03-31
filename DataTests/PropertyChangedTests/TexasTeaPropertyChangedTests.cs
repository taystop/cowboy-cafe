using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTeaPropertyChangedTests
    {
        // Test 1: Texas Tea should implement INotifyPropertyChanged
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }
        // Test 2: Changing Size should invoke propertychanged on Size
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Small;
            });
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Medium;
            });
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = Size.Large;
            });
        }
        // Test 3: Changing Size should invoke propertychanged on Price
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Small;
            });
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Medium;
            });
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = Size.Large;
            });
        }
        // Test 4: Changing Size should invoke propertychanged on Calories
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Small;
            });
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Medium;
            });
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = Size.Large;
            });
        }
        // Test 5: Changing Size should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Size = Size.Small;
            });
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Size = Size.Medium;
            });
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Size = Size.Large;
            });
        }
        // Test 6: Changing Sweet should invoke propertychanged on Sweet
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedOnSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = false;
            });
        }
        // Test 7: Changing Sweet should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingSweetShouldInvokePropertyChangedOnSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Sweet = false;
            });
        }
        // Test 8: Changing Ice should invoke propertychanged on Ice
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedOnIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });
        }
        // Test 9: Changing Ice should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedOnSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });
        }
        // Test 10: Changing Lemon should invoke propertychanged on Lemon
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedOnLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = true;
            });
        }
        // Test 11: Changing Lemon should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedOnSpecialInstuctions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;
            });
        }
    }
}
