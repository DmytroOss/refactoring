using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRose.Factory;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 10, Quality = 20 } };
            Rose app = new  Rose(Items, new UpdateQualityStrategyFactory());
            app.UpdateQuality();
            Assert.Equal("Conjured Mana Cake", Items[0].Name);
        }
    }
}
