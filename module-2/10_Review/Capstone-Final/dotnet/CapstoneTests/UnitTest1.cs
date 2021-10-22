using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Capstone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChangeMaker()
        {
            // IWrite writer = new ConsoleIO();
            // Capstone.
            VendingMachine testVm = new VendingMachine(null, null);

            Dictionary<string, int> dictionary = testVm.MakeChange(2.15M);

            Assert.AreEqual(8, dictionary["quarter"]);

        }
    }
}
