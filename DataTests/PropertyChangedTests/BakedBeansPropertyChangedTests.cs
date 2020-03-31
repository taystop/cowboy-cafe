using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        // Test 1: Baked Beans should implement INotifyPropertyChanged
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }
        // Test 2: Changing Size should invoke propertychanged on Size
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSize()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Small;
            });
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Medium;
            });
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = Size.Large;
            });
        }
        // Test 3: Changing Size should invoke propertychanged on Price
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnPrice()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Small;
            });
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Medium;
            });
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = Size.Large;
            });
        }
        // Test 4: Changing Size should invoke propertychanged on Calories
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnCalories()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Small;
            });
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Medium;
            });
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = Size.Large;
            });
        }
        // Test 5: Changing Size should invoke propertychanged on SpecialInstructions
        [Fact]
        public void ChangingSizeShouldIvokePropertyChangedOnSpecialInstructions()
        {
            var beans = new BakedBeans();
            Assert.PropertyChanged(beans, "SpecialInstructions", () =>
            {
                beans.Size = Size.Small;
            });
            Assert.PropertyChanged(beans, "SpecialInstructions", () =>
            {
                beans.Size = Size.Medium;
            });
            Assert.PropertyChanged(beans, "SpecialInstructions", () =>
            {
                beans.Size = Size.Large;
            });
        }
    }
}
