using System.Collections.Generic;
using System;
using csharpcore.Items;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;

        IList<RegularItem> RegularItems = new List<RegularItem>();
        IList<AgedItem> AgedItems = new List<AgedItem>();
        IList<SulfurasItem> SulfurasItems = new List<SulfurasItem>();
        IList<BackstagePassItem> BackstagePassItems = new List<BackstagePassItem>();
        IList<ConjuredItem> ConjuredItems = new List<ConjuredItem>();

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;

            foreach (Item item in this.Items)
            {
                if (item.Name.Contains(AgedItem.KeyWord))
                    AgedItems.Add(new AgedItem(item));
                else if (item.Name.Contains(SulfurasItem.KeyWord))
                    SulfurasItems.Add(new SulfurasItem(item));
                else if (item.Name.Contains(BackstagePassItem.KeyWord))
                    BackstagePassItems.Add(new BackstagePassItem(item));
                else if (item.Name.Contains(ConjuredItem.KeyWord))
                    ConjuredItems.Add(new ConjuredItem(item));
                else
                    RegularItems.Add(new RegularItem(item));
            }
        }

        public void UpdateQuality()
        {
            foreach (RegularItem regularItem in RegularItems) { regularItem.UpdateQuality(); regularItem.UpdateItemValues(); }
            foreach (AgedItem agedItem in AgedItems) { agedItem.UpdateQuality(); agedItem.UpdateItemValues(); }
            foreach (SulfurasItem sulfurasItem in SulfurasItems) { sulfurasItem.UpdateQuality(); sulfurasItem.UpdateItemValues(); }
            foreach (BackstagePassItem backstagePassItem in BackstagePassItems) { backstagePassItem.UpdateQuality(); backstagePassItem.UpdateItemValues(); }
            foreach (ConjuredItem conjuredItem in ConjuredItems) { conjuredItem.UpdateQuality(); conjuredItem.UpdateItemValues(); }
        }
    }
}
