using GildedRose.Inventory.Items.Abstract;
using System;

namespace GildedRose.Inventory.Items.Concrete
{
    public class Sulfuras : Item
    {

        public Sulfuras(string name, int sellIn, int quality) :base(name, sellIn, quality)
        {
        }

        public override void CheckParameters(int quality)
        {
            if (quality < _minQuality)
                throw new Exception(string.Format("Quality for Sulfuras must be greater than {0}", _minQuality));
        }

        public override void UpdateSellIn()
        {
        }

        public override void UpdateQuality()
        {
        }
    }
}
