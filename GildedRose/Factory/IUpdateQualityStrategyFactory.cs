using GildedRose.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Factory
{
    public interface IUpdateQualityStrategyFactory
    {
        IUpdateQualityStrategy Update(string itemName);
    }
}
