using GildedRose.Inventory.Items.Abstract;
using System;
using System.Collections.Generic;
using GildedRose.Inventory.Items.Factory;
using GildedRose.Inventory;

namespace GildedRose.Program
{
    public class Simulation
    {
        public static void Main(string[] args)
        {
            var items = new List<Item>()
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

            var simulation = new Simulation();
            var days = 30;

            // Simulation during 30 days period
            for (int i = 1; i <= days; i++)
            {
                Console.WriteLine(string.Format("Day {0}", i));
                simulation.UpdateItemQuality(items);
            }
           
            Console.Read();
        }

        public void UpdateItemQuality(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                item.Update();
                Console.WriteLine(item.ToString());
            }
        }
    }
}
