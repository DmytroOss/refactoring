using GildedRose.Factory;
using GildedRose.Strategies;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Rose
    {
        IList<Item> Items;
        private IUpdateQualityStrategyFactory factory;
        public Rose(IList<Item> Items, IUpdateQualityStrategyFactory factory)
        {
            this.Items = Items;
            this.factory = factory;
        }
        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                IUpdateQualityStrategy updateQualityStrategy = factory.Update(item.Name);
                updateQualityStrategy.UpdateQuality(item);
            }
        }
    }
}
