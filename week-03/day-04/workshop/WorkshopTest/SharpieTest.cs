using System;
using System.Collections.Generic;
using System.Text;
using workshop;
using Xunit;


namespace WorkshopTest
{
    public class SharpieTest
    {
        Sharpie sharpie = new Sharpie("red", 10);

        [Fact]
        public void IsColorValid()
        {
            bool expectOutput = true;

            bool actualOutput = false;
            Sharpie sharpie1 = new Sharpie("red", 10);
            char[] sharpieCharArray = sharpie1.Color.ToCharArray();
            foreach (var VARIABLE in sharpieCharArray)
            {
                if (!((VARIABLE >= 'A' && VARIABLE <= 'Z') || (VARIABLE >= 'a' && VARIABLE <= 'z')))
                {
                    actualOutput = false;
                    break;
                }
                else
                {
                    actualOutput = true;
                }
            }
            
            Assert.Equal(expectOutput, actualOutput);
        }

        [Fact]
        public void InkAmountSubstractByOne()
        {
            double expectOutput = 99;

            sharpie.Use();
            double actualOutput = sharpie.InkAmount;

            Assert.Equal(expectOutput, actualOutput);
        }

        [Fact]
        public void ReturnInkAmountCorrectly()
        {
            double expectOutput = 100;

            double actualOutput = sharpie.GetInkAmount();

            Assert.Equal(expectOutput, actualOutput);
        }
    }
}
