using GildedRoseKata;

namespace GildedRose.Strategies
{
    internal class BackstagePasses : IUpdateQualityStrategy
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                if (item.SellIn > 10)
                    item.Quality++;
                else if (item.SellIn <= 10 && item.SellIn > 5)
                {
                    item.Quality += 2;
                }
                else if (item.SellIn <= 5)
                    item.Quality += 3;
            }
            item.SellIn--;
            if (item.SellIn < 0)
                item.Quality = 0;
        }
    }
}