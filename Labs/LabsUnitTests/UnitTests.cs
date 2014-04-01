using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethsAndUnits;

namespace LabsUnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void FindDelimTest()
        {
            Assert.AreEqual(Program.FindDelim(10,4), 2);
        }
    }
}
