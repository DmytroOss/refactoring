using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    internal class Conjured : IUpdateQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            if(item.Quality < 50)
            {
                item.Quality -= 2;
                if (item.SellIn <= 0 && item.Quality < 50)
                {
                    item.Quality -= 2;
                }
            }
            item.SellIn--;
        }
    }
}
