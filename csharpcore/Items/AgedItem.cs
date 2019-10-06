using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    class AgedItem : Item, ICustomItem
    {
        public readonly static string KeyWord = "Aged";
        private Item Item;

        public AgedItem(Item Item)
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
            if (SellIn > 0)
                Quality += 1;
            else
                Quality += 2;

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
