using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]

    public class Tests
    {
        //[Test]

        //public void SimpleTest()
        //{
        //    Assert.IsTrue(1 == 1);
        //}
        [Test]
        public void NegativerMpreis()
        {
            Assert.Catch(() => // catch = es muss eine exception auftreten
            {
                var x = new Mech("Bezeichnung", "Klasse", 20, -20);
            });
        }
        [Test]
        public void NegativeMtonnage()
        {
            Assert.Catch(() => // catch = es muss eine exception auftreten
            {
                var x = new Mech("Bezeichnung", "Klasse", -20, 20);
            });
        }
        [Test]
        public void LeereMbezeichnung()
        {
            Assert.Catch(() => // catch = es muss eine exception auftreten
            {
                var x = new Mech("", "Klasse", 20, 20);
            });
        }
        [Test]
        public void LeereMklasse()
        {
            Assert.Catch(() => // catch = es muss eine exception auftreten
            {
                var x = new Mech("Bezeichnung", "", 20, 20);
            });
        }
        [Test]
        public void NegativerTpreis()
        {
            Assert.Catch(() => // catch = es muss eine exception auftreten
            {
                var x = new Tank("Bezeichnung", "Klasse", 20, -20);
            });
        }
        [Test]
        public void NegativeTtonnage()
        {
            Assert.Catch(() => // catch = es muss eine exception auftreten
            {
                var x = new Tank("Bezeichnung", "Klasse", -20, 20);
            });
        }
        [Test]
        public void LeereTbezeichnung()
        {
            Assert.Catch(() => // catch = es muss eine exception auftreten
            {
                var x = new Tank("", "Klasse", 20, 20);
            });
        }
        [Test]
        public void LeereTantrieb()
        {
            Assert.Catch(() => // catch = es muss eine exception auftreten
            {
                var x = new Tank("Bezeichnung", "", 20, 20);
            });
        }
    }
}
