using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    class BackstagePassItem : Item, ICustomItem
    {
        public readonly static string KeyWord = "Backstage passes";
        private Item Item;

        public BackstagePassItem(Item Item)
        {
            this.Item = Item;

            Name = Item.Name;
            Quality = QualityRangeCheck(Item.Quality);
            SellIn = Item.SellIn;
        }

        private int QualityRangeCheck(int quality)
        {
            if (quality < 0)
                return 0;
            else if (quality > 50)
                return 50;
            else
                return quality;
        }

        public void UpdateQuality()
        {
            if (SellIn < 0)
                Quality = 0;
            else if (SellIn <= 5)
                Quality += 3;
            else if (SellIn <= 10)
                Quality += 2;
            else
                Quality += 1;

            Quality = QualityRangeCheck(Quality);

            SellIn--;
        }

        public void UpdateItemValues()
        {
            Item.Quality = Quality;
            Item.SellIn = SellIn;
        }
    }
}
