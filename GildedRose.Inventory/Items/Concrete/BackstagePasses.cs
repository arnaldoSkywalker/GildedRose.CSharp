using GildedRose.Inventory.Items.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Inventory.Items.Concrete
{
    public class BackstagePasses : IncrementItem
    {
        public BackstagePasses(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateSellIn()
        {
            SellIn--;

            if (IsDatePassed())
            {
                Quality = 0;
                _qualityDegradeRate = 0;
                return;
            }

            if (SellIn <= 10 && SellIn > 5)
            {
                _qualityDegradeRate = 2;
            }
            else if (SellIn <= 5)
            {
                _qualityDegradeRate = 3;
            }
        }

    }
}
