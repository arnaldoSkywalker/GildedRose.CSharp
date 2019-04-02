using GildedRose.Inventory.Items.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Inventory.Items.Abstract
{
    public abstract class IncrementItem : Item
    {
        public IncrementItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            Quality += Quality + _qualityDegradeRate < _maxQuality ? _qualityDegradeRate : _maxQuality - Quality;
        }
    }
}
