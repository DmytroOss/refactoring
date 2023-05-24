using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Strategies
{
    public interface IUpdateQualityStrategy
    {
        void UpdateQuality(Item item);
    }
}
