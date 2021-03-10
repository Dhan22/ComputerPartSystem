using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartClasses;

namespace Lost_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instacne of the class 
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);

        }
    }
}
