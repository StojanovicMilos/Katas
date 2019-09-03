using System.Collections.Generic;

namespace GildedRose
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                UpdateQuality(item);
            }
        }

        public static Item UpdateQuality(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie":
                    return UpdateAgedBrie(item);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return UpdateConcert(item);
                case "Sulfuras, Hand of Ragnaros":
                    return UpdateSulfuras(item);
                default:
                    return DefaultUpdate(item);
            }
        }

        private static Item UpdateAgedBrie(Item item)
        {
            item.SellIn = item.SellIn - 1;
            if (item.Quality >= 50)
                return item;
            item.Quality = item.Quality + 1;
            if (item.SellIn >= 0)
                return item;
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }

            return item;
        }

        private static Item UpdateConcert(Item item)
        {
            if (item.SellIn < 6 && item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
            if (item.SellIn < 11)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }

                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
                item.SellIn = item.SellIn - 1;
                if (item.SellIn < 0)
                {
                    item.Quality = 0;
                }

                return item;
            }

            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }

            item.SellIn = item.SellIn - 1;

            return item;
        }

        private static Item UpdateSulfuras(Item item)
        {
            return item;
        }

        private static Item DefaultUpdate(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
            }

            return item;
        }
    }
}