using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDHomeworkDay1Test
{
    [TestClass]
    public class DataProcessorsTest
    {
        [TestMethod]
        public void 驗證三筆一組取得Cost欄位總和()
        {
            //arrange
            var target = new DataProcessors();
            var sourceDatas = new List<TestDataModel> {            
                new TestDataModel() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new TestDataModel() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new TestDataModel() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new TestDataModel() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new TestDataModel() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new TestDataModel() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new TestDataModel() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new TestDataModel() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new TestDataModel() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new TestDataModel() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new TestDataModel() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };
            int numberOfGroups = 3;
            string propertyName = "Cost";
            var expected = new int[] { 6, 15, 24, 21 };

            //act
            var actual = target.GroupAndSum(sourceDatas, propertyName, numberOfGroups);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 驗證四筆一組取得Revenue欄位總和()
        {
            //arrange
            var target = new DataProcessors();
            var sourceDatas = new List<TestDataModel> {            
                new TestDataModel() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 },
                new TestDataModel() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 },
                new TestDataModel() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 },
                new TestDataModel() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 },
                new TestDataModel() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 },
                new TestDataModel() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 },
                new TestDataModel() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 },
                new TestDataModel() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 },
                new TestDataModel() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 },
                new TestDataModel() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 },
                new TestDataModel() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 }
            };
            int numberOfGroups = 4;
            string propertyName = "Revenue";
            var expected = new int[] { 50, 66, 60 };

            //act
            var actual = target.GroupAndSum(sourceDatas, propertyName, numberOfGroups);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        public class TestDataModel
        {
            public int Id { get; set; }
            public int Cost { get; set; }
            public int Revenue { get; set; }
            public int SellPrice { get; set; }
        }
    }
}
