using NUnit.Framework;
using NunitDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitLib
{ [TestFixture]
    public class Class1
    {
        Calc cal;

        [SetUp]
        public void Initialize()
        {
            cal = new Calc();
        }

        [Test]
        public void TestAdd()
        {

            Assert.AreEqual(5, cal.Add(2, 3));
        }

        [Test]
        public void TestAdd1()
        {

            Assert.AreEqual(5, cal.Add(2, 3));
        }

        [TearDown]
        public void Destroy()
        {
            cal = null;
        }
    }
}
