using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        private Item ExecuteUpdate(string name, int sellIn, int quality, int days = 1)
        {
            Item item = new Item() { Name = name, Quality = quality, SellIn = sellIn };
            Program.Items = new List<Item> { item };
            GildedRose gildedRose = new GildedRose(Program.Items);

            for (int i = 0; i < days; i++)
                gildedRose.UpdateQuality();

            return item;
        }

        [Fact]
        public void TestOfItemQualityNeverNegative()
        {
            Item item;

            item = ExecuteUpdate("+5 Dexterity Vest", 10, -20);
            Assert.False(item.Quality < 0);

            item = ExecuteUpdate("Aged Brie", 2, -10);
            Assert.False(item.Quality < 0);

            item = ExecuteUpdate("Conjured Mana Cake", 3, -6);
            Assert.False(item.Quality < 0);

            item = ExecuteUpdate("Backstage passes to a TAFKAL80ETC concert", 15, -20);
            Assert.False(item.Quality < 0);

            item = ExecuteUpdate("Sulfuras, Hand of Ragnaros", 1, -80);
            Assert.False(item.Quality < 0);
        }

        [Fact]
        public void TestRegularItems()
        {
            Item item;

            //Test of SellIn and Quality behaviour
            item = ExecuteUpdate("+5 Dexterity Vest", 10, 20);
            Assert.Equal(9, item.SellIn);
            Assert.Equal(19, item.Quality);

            //Test of decrease blockade on value 0 for Quality
            item = ExecuteUpdate("+5 Dexterity Vest", 10, 20, 30);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void TestAgedItems()
        {
            Item item;

            //Test of SellIn and Quality behaviour
            item = ExecuteUpdate("Aged Brie", 2, 0);
            Assert.Equal(1, item.SellIn);
            Assert.Equal(1, item.Quality);

            //Test of increase blockade on value 50 for Quality
            item = ExecuteUpdate("Aged Brie", 10, 20, 40);
            Assert.Equal(50, item.Quality);
        }

        [Fact]
        public void TestConjuredItems()
        {
            Item item;

            //Test of SellIn and Quality behaviour
            item = ExecuteUpdate("Conjured Mana Cake", 3, 6);
            Assert.Equal(2, item.SellIn);
            Assert.Equal(4, item.Quality);

            //Test of decrease blockade on value 0 for Quality
            item = ExecuteUpdate("Conjured Mana Cake", 3, 6, 20);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void TestBackstagePassItems()
        {
            Item item;

            //Test of SellIn and Quality behaviour
            item = ExecuteUpdate("Backstage passes to a TAFKAL80ETC concert", 15, 20);
            Assert.Equal(14, item.SellIn);
            Assert.Equal(21, item.Quality);

            //Double the speed of Quality Increase
            item = ExecuteUpdate("Backstage passes to a TAFKAL80ETC concert", 10, 20);
            Assert.Equal(9, item.SellIn);
            Assert.Equal(22, item.Quality);

            //Three times the speed of Quality Increase
            item = ExecuteUpdate("Backstage passes to a TAFKAL80ETC concert", 5, 20);
            Assert.Equal(4, item.SellIn);
            Assert.Equal(23, item.Quality);

            //Quality drops to 0
            item = ExecuteUpdate("Backstage passes to a TAFKAL80ETC concert", 0, 20, 2);
            Assert.Equal(-2, item.SellIn);
            Assert.Equal(0, item.Quality);

            //Test of decrease blockade on value 0 for Quality
            item = ExecuteUpdate("Backstage passes to a TAFKAL80ETC concert", 15, 20, 30);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void TestSulfurasItems()
        {
            Item item;

            //Test of SellIn and Quality behaviour
            item = ExecuteUpdate("Sulfuras, Hand of Ragnaros", 1, 80);
            Assert.Equal(1, item.SellIn);
            Assert.Equal(80, item.Quality);

            //Long term behaviour
            item = ExecuteUpdate("Sulfuras, Hand of Ragnaros", 1, 80, 30);
            Assert.Equal(1, item.SellIn);
            Assert.Equal(80, item.Quality);
        }
    }
}