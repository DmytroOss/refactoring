using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    internal class Aged_Brie : IUpdateQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            if(item.Quality < 50)
            {
                item.Quality++;
            }
            if(item.SellIn <= 0 && item.Quality < 50)
            {
                item.Quality++;
            }
        }
    }
}
