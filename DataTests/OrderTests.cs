﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class OrderTests
    {
        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; } 

            public List<string> SpecialInstructions { get; set; } 
        }

        [Fact]
        public void Shouldbeabletoadditems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void Shouldbeabletoremoveitems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Fact]
        public void Shouldbeabletogetenumerateditems()
        {
            var order = new Order();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            var item3 = new MockOrderItem();
            order.Add(item1);
            order.Add(item2);
            order.Add(item3);
            Assert.Collection(order.Items,
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item),
                item => Assert.Equal(item3, item));
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] {0,0.3,0})]
        [InlineData(new double[] { 199.34, 799 })]
        [InlineData(new double[] { 798 })]
        [InlineData(new double[] {  })]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] { -4, 10, 8})]
        [InlineData(new double[] { 3.13425234262 })]
        [InlineData(new double[] { double.NaN })]
        public void Subtotalshouldbesumofitemprices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem() { Price = price });
            }

            Assert.Equal(total, order.Subtotal);
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void AddingItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () => { order.Add(item); });
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]
        public void RemovingItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () => { order.Remove(item); });
        }
    }
}
