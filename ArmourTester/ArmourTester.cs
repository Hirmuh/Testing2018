using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;

namespace ArmourTester
{
    [TestClass]
    public class ArmourTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int lvl = ar.getLevel();

            if (lvl != 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int slot = ar.getSlot();

            Assert.IsTrue(slot == 2);
            
        }

        [TestMethod]
        public void TestMethod3()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int maxProt = ar.getMaxProt();
            int curProt = ar.getCurProt();

            if (curProt / maxProt == 20)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int lvl = ar.getLevel();

            Assert.AreEqual(lvl, 2);
            
        }

    }
}
