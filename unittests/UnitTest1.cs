using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace bd.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestUserRoleId()
        {
            User.roleId = 1;
            Assert.AreEqual(1, User.roleId);
        }

        [TestMethod]
        public void TestUserId()
        {
            User.userId = 2;
            Assert.AreEqual(2, User.userId);
        }

        [TestMethod]
        public void TestAddToOrderList()
        {
            var drug = new medicinedrug(1, 10, 200.5f);
            orderlist.Add(drug);
            Assert.AreEqual(1, orderlist.GetOrderList().Count);
        }

        [TestMethod]
        public void TestAddExistingDrugToOrderList()
        {
            var drug1 = new medicinedrug(1, 10, 450.49f);
            var drug2 = new medicinedrug(1, 5, 500.25f);
            orderlist.Add(drug1);
            orderlist.Add(drug2);
            Assert.AreEqual(15, orderlist.GetOrderList().First().quantity);
        }

        [TestMethod]
        public void TestRemoveFromOrderList()
        {
            var drug = new medicinedrug(1, 10, 159.99f);
            orderlist.Add(drug);
            orderlist.Remove(1);
            Assert.AreEqual(0, orderlist.GetOrderList().Count);
        }

        [TestMethod]
        public void TestAddQuantityToOrderList()
        {
            orderlist.Orderlist = new List<medicinedrug>();
            var drug = new medicinedrug(1, 10, 200.00f);
            orderlist.Add(drug);
            orderlist.AddQuantity(1, 5);
            Assert.AreEqual(15, orderlist.GetOrderList().First().quantity);
        }

        [TestMethod]
        public void TestRemoveQuantityFromOrderList()
        {
            var drug = new medicinedrug(1, 10, 199.99f);
            orderlist.Add(drug);
            orderlist.RemoveQuantity(1, 5);
            Assert.AreEqual(5, orderlist.GetOrderList().First().quantity);
        }

        [TestMethod]
        public void TestRemoveQuantityToZeroFromOrderList()
        {
            orderlist.Orderlist = new List<medicinedrug>();
            var drug = new medicinedrug(1, 10, 150.00f);
            orderlist.Add(drug);
            orderlist.RemoveQuantity(1, 10);
            Assert.AreEqual(0, orderlist.GetOrderList().Count);
        }

        [TestMethod]
        public void TestGetOrderList()
        {
            orderlist.Orderlist = new List<medicinedrug>();
            var drug = new medicinedrug(1, 10, 200f);
            orderlist.Add(drug);
            var orderList = orderlist.GetOrderList();
            Assert.AreEqual(1, orderList.Count);
            Assert.AreEqual(10, orderList.First().quantity);
        }

        [TestMethod]
        public void TestMedicineDrugConstructor()
        {
            var drug = new medicinedrug(1, 10, 200);
            Assert.AreEqual(1, drug.id);
            Assert.AreEqual(10, drug.quantity);
            Assert.AreEqual(200f, drug.price);
        }
    }
}