using GildedRose.Inventory.Items.Abstract;

namespace GildedRose.Inventory.Items.Concrete
{
    public class AgedBrie : IncrementItem
    {

        public AgedBrie(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

    }
}
