using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    internal class Sulfuras : IUpdateQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.Quality = 80;
        }
    }
}
