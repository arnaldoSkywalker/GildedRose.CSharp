using System;
using System.Collections.Generic;

namespace GildedRose.Inventory.Items.Abstract
{
    public class Item : IEquatable<Item>
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        protected int _qualityDegradeRate;
        protected static int _incrementFactor = -1;
        protected static int _maxQuality = 50;
        protected static int _minQuality = 0;

        public Item() { }

        public Item(Item i)
        {
            Name = i.Name;
            Quality = i.Quality;
            SellIn = i.SellIn;
        }

        public Item(string name, int sellIn, int quality)
        {
            CheckParameters(quality);

            Name = name;
            SellIn = sellIn;
            Quality = quality;
            _qualityDegradeRate = 1;
        }

        public virtual void CheckParameters(int quality)
        {
            if (quality > _maxQuality || quality < _minQuality)
                throw new Exception("Quality must be in the range [0, 50]");
        }

        public void Update()
        {
            UpdateSellIn();
            UpdateQuality();
        }

        public virtual void UpdateSellIn()
        {
            if (IsDatePassed())
                _qualityDegradeRate = 2;
            
            SellIn--;
        }

        public virtual void UpdateQuality()
        {
            Quality = Quality - (Quality - _qualityDegradeRate >= 0 ? _qualityDegradeRate : Quality);
        }

        protected bool IsDatePassed()
        {
            return SellIn <= 0;
        }

        public override string ToString()
        {
            return Name + ", S:" + SellIn + ", Q:" + Quality;
        }

        public bool Equals(Item other)
        {
            if (other == null)
                return false;
            if (Name.Equals(other.Name) && Quality.Equals(other.Quality) && SellIn.Equals(other.SellIn))
                return true;
            else
                return false;
        }
    }
}
