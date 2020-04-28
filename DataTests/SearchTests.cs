using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class SearchTests
    {
        // Test 1: Searching for null value should return full menu
        [Fact]
        public void NullSearchReturnsFullMenu()
        {
            var result = Menu.Search(null);
        }

        // Test 2: Searching for individual letter should return all menu items with that letter
        [Fact]
        public void SingleLetterSearchReturnsAllItemsWithLetter()
        {
            var result = Menu.Search("A");
        }

        // Test 3: Searching for specific item name should return that item
    }
}
