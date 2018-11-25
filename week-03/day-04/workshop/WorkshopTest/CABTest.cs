using System;
using System.Collections.Generic;
using System.Text;
using workshop;
using Xunit;

namespace WorkshopTest
{
    public class CABTest
    {
        CAB newObj = new CAB();

        [Fact]
        public void ConstructorStateTest()
        {
            string expectState = "playing";

            Assert.Equal(expectState, newObj.State);
        }

        [Fact]
        public void ConstructorCounterTest()
        {
            List<int> expectCounter = new List<int> { 0, 0 };

            Assert.Equal(expectCounter, newObj.Counter);
        }
    }
}
