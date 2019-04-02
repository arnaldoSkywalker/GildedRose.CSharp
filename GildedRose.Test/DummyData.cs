using System.Collections.Generic;
using GildedRose.Inventory.Items.Factory;
using GildedRose.Inventory.Items.Abstract;

namespace Test
{
    public class DummyData
    {
        public static Dictionary<string, Item> DummyTestBelowMaxQuality = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.AgedBrie, 2, 50)},
            {"Output", ItemFactory.GetItemType(ItemName.AgedBrie, 1, 50)}
        };

        public static Dictionary<string, Item> DummyTestNonNegative = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.Item, -2, 0)},
            {"Output", ItemFactory.GetItemType(ItemName.Item, -3, 0) }
        };

        public static Dictionary<string, Item> DummyTestQualityDecreasedTwice = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.Item, 0, 20)},
            {"Output", ItemFactory.GetItemType(ItemName.Item, -1, 18) }
        };

        public static Dictionary<string, Item> DummyTestAgedBrieIncreaseQualityTwice = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.AgedBrie, 2, 0)},
            {"Output", ItemFactory.GetItemType(ItemName.AgedBrie, 1, 1) }
        };

        public static Dictionary<string, Item> DummyTestIncreasedByThreeLessFiveDaysBackstage = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.Backstage, 5, 20)},
            {"Output", ItemFactory.GetItemType(ItemName.Backstage, 4, 23) }
        };

        public static Dictionary<string, Item> DummyTestQualityIncreasedByTwoLessEqualToTenDaysBackstagePasses = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.Backstage, 9, 40)},
            {"Output", ItemFactory.GetItemType(ItemName.Backstage, 8, 42) }
        };

        public static Dictionary<string, Item> DummyTestQualityZeroSellInPassed = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.Backstage, 0, 40)},
            {"Output", ItemFactory.GetItemType(ItemName.Backstage, -1, 0) }
        };

        public static Dictionary<string, Item> DummyTestQualityIncreaseMoreTenDaysBackstagePasses = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.Backstage, 19, 40)},
            {"Output", ItemFactory.GetItemType(ItemName.Backstage, 18, 41) }
        };

        public static Dictionary<string, Item> DummyTestQualityStaticSulfuras = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.Sulfuras, 0, 40)},
            {"Output", ItemFactory.GetItemType(ItemName.Sulfuras, 0, 40) }
        };

        public static Dictionary<string, Item> DummyTestQualityDecreasedTwiceConjured = new Dictionary<string, Item>
        {
            {"Input", ItemFactory.GetItemType(ItemName.Conjured, 13, 40)},
            {"Output", ItemFactory.GetItemType(ItemName.Conjured, 12, 38) }
        };

        public static List<Item> DummyDefultItems = new List<Item>()
        {
            ItemFactory.GetItemType(ItemName.Item, 10, 20),
            ItemFactory.GetItemType(ItemName.AgedBrie, 2, 0),
            ItemFactory.GetItemType(ItemName.Item, 5, 7),
            ItemFactory.GetItemType(ItemName.Sulfuras, 0, 80),
            ItemFactory.GetItemType(ItemName.Sulfuras, -1, 80),
            ItemFactory.GetItemType(ItemName.Backstage, 15,20),
            ItemFactory.GetItemType(ItemName.Backstage, 10, 49),
            ItemFactory.GetItemType(ItemName.Backstage, 5, 49),
            ItemFactory.GetItemType(ItemName.Conjured, 3, 6)
        };

        public static List<Item> DummyDefultItemsOutputs = new List<Item>()
        {
            ItemFactory.GetItemType(ItemName.Item, -20, 0),
            ItemFactory.GetItemType(ItemName.AgedBrie, -28, 50),
            ItemFactory.GetItemType(ItemName.Item, -25, 0),
            ItemFactory.GetItemType(ItemName.Sulfuras, 0, 80),
            ItemFactory.GetItemType(ItemName.Sulfuras, -1, 80),
            ItemFactory.GetItemType(ItemName.Backstage, -15, 0),
            ItemFactory.GetItemType(ItemName.Backstage, -20, 0),
            ItemFactory.GetItemType(ItemName.Backstage, -25, 0),
            ItemFactory.GetItemType(ItemName.Conjured, -27, 0)
        };
    }
}
