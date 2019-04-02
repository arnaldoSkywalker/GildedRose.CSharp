using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace GildedRose.Test
{
    [TestClass]
    public class GildedRoseTest
    {
        [TestMethod]
        public void CheckDefaultOutput()
        {
            var items = DummyData.DummyDefultItems;
            var days = 30;
            for (int i = 1; i <= days; i++)
            {
                foreach (var item in items)
                    item.Update();
            }

            var expectedOutput = DummyData.DummyDefultItemsOutputs;

            Assert.IsTrue(expectedOutput[0].Equals(items[0]));
            Assert.IsTrue(expectedOutput[1].Equals(items[1]));
            Assert.IsTrue(expectedOutput[2].Equals(items[2]));
            Assert.IsTrue(expectedOutput[3].Equals(items[3]));
            Assert.IsTrue(expectedOutput[4].Equals(items[4]));
            Assert.IsTrue(expectedOutput[5].Equals(items[5]));
            Assert.IsTrue(expectedOutput[6].Equals(items[6]));
            Assert.IsTrue(expectedOutput[7].Equals(items[7]));
            Assert.IsTrue(expectedOutput[8].Equals(items[8]));
        }

        #region Items

        [TestMethod]
        public void QualityBelowFifty()
        {
            var items = DummyData.DummyTestBelowMaxQuality;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));
        }

        [TestMethod]
        public void QualityAboveZero()
        {
            var items = DummyData.DummyTestNonNegative;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));
        }

        [TestMethod]
        public void DatePassedQualityReducedTwice()
        {
            var items = DummyData.DummyTestQualityDecreasedTwice;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));
        }

        #endregion

        #region AgedBrie Tests

        [TestMethod]
        public void QualityAgedBrieIncreasedOverTime()
        {
            var items = DummyData.DummyTestAgedBrieIncreaseQualityTwice;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));
        }

        #endregion

        #region Backstage Tests

        [TestMethod]
        public void QualityIncreasedThreeLessFiveDaysBackstagePasses()
        {
            var items = DummyData.DummyTestIncreasedByThreeLessFiveDaysBackstage;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));
        }

        [TestMethod]
        public void QualityIncreaseMoreTenDaysBackstagePasses()
        {
            var items = DummyData.DummyTestQualityIncreaseMoreTenDaysBackstagePasses;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));
        }

        [TestMethod]
        public void QualityZeroSellInDatePassedBackstagePasses()
        {
            var items = DummyData.DummyTestQualityZeroSellInPassed;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));

        }

        [TestMethod]
        public void QualityIncreasedByTwoIfLessThanOrEqualToTenDaysBackstagePasses()
        {
            var items = DummyData.DummyTestQualityIncreasedByTwoLessEqualToTenDaysBackstagePasses;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));
        }

        #endregion

        #region Sulfuras Tests

        [TestMethod]
        public void QualityStaticSulfuras()
        {
            var items = DummyData.DummyTestQualityStaticSulfuras;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));
        }

        #endregion

        #region Conjured Tests

        [TestMethod]
        public void DecreaseQualityTwiceAsRegular()
        {
            var items = DummyData.DummyTestQualityDecreasedTwiceConjured;
            items["Input"].Update();

            var expectedOutput = items["Output"];

            Assert.IsTrue(expectedOutput.Equals(items["Input"]));
        }

        #endregion
    }
}

