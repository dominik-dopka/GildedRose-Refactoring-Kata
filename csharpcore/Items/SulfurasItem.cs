using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    class SulfurasItem : Item, ICustomItem
    {
        public readonly static string KeyWord = "Sulfuras";
        private Item Item;

        public SulfurasItem(Item Item)
        {
            this.Item = Item;

            Name = Item.Name;
            Quality = 80;
            SellIn = Item.SellIn;
        }

        public void UpdateQuality()
        {
            Quality = 80;
        }

        public void UpdateItemValues()
        {
            Item.Quality = Quality;
            Item.SellIn = SellIn;
        }
    }
}
