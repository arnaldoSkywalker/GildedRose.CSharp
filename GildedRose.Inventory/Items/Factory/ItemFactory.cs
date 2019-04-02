using GildedRose.Inventory.Items.Abstract;
using GildedRose.Inventory.Items.Concrete;

namespace GildedRose.Inventory.Items.Factory
{
    public class ItemFactory
    {
            public static Item GetItemType(ItemName itemName, int sellIn, int quality)
            {
                switch (itemName)
                {
                    case ItemName.Sulfuras:
                        return new Sulfuras(itemName.ToString(), sellIn, quality);
                    case ItemName.AgedBrie:
                        return new AgedBrie(itemName.ToString(), sellIn, quality);
                    case ItemName.Backstage:
                        return new BackstagePasses(itemName.ToString(), sellIn, quality);
                    case ItemName.Conjured:
                        return new Conjured(itemName.ToString(), sellIn, quality);
                default:
                        return new Item(itemName.ToString(), sellIn, quality);
                }
            }
    }
}
