using GildedRose.Inventory.Items.Abstract;

namespace GildedRose.Inventory.Items.Concrete
{
    public class Conjured : Item
    {

        public Conjured(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
            _qualityDegradeRate = 2;
        }
    }
}
