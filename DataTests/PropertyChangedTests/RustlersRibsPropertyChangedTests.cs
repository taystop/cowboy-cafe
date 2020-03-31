using System;
using Xunit;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class RustlersRibsPropertyChangedTests
    {
        // Test 1: Rustlers Ribs should implement INotifyPropertyChanged
        [Fact]
        public void RustlersRibsShouldImplementINotifyPropertyChanged()
        {
            var rib = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(rib);
        }
    }
}
