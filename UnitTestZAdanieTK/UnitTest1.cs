using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ZadanieTK;

namespace UnitTestZAdanieTK
{
    [TestClass]
    public class UnitTestZAdanieTK
    {
        [TestMethod]
        public void PositiveTest1()
        {
            int expected = 5;
            int modul1 = 22;
            int modul2 = 38;
            int modul3 = 20;

            int result = Zadanie.Max(modul1) + Zadanie.Max(modul2) + Zadanie.Max(modul3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PositiveTest2()
        {
            int expected = 4;
            int modul1 = 16;
            int modul2 = 32;
            int modul3 = 16;

            int result = Zadanie.Max(modul1) + Zadanie.Max(modul2) + Zadanie.Max(modul3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PositiveTest3()
        {
            int expected = 3;
            int modul1 = 10;
            int modul2 = 20;
            int modul3 = 10;

            int result = Zadanie.Max(modul1) + Zadanie.Max(modul2) + Zadanie.Max(modul3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NegativeTest1()
        {
            int expected = -1;
            int modul1 = -1;
 
            int result = Zadanie.Max(modul1);

            Assert.AreEqual(expected, result);
        }
    }
}

