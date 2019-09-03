using System.Collections.Generic;
using System.Linq;
using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using Xunit;

namespace GildedRose.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseTests
    {
        [Fact]
        public void XunitWorks()
        {
            Assert.True(true);
        }

        [Fact]
        public void ApprovalTests()
        {
            IEnumerable<string> names = new[]
            {
                "other",
                "Aged Brie",
                "Backstage passes to a TAFKAL80ETC concert",
                "Sulfuras, Hand of Ragnaros"
            };
            IEnumerable<int> sellIns = Enumerable.Range(-5, 30);
            IEnumerable<int> qualities = Enumerable.Range(-5, 60);

            CombinationApprovals.VerifyAllCombinations(
                (name, sellIn, quality) =>
                    GildedRose.UpdateQuality(new Item {Name = name, SellIn = sellIn, Quality = quality}),
                names, sellIns, qualities);
        }
    }
}
