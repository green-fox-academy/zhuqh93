using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WorkshopTest
{
    public class ExtensionTests
    {
        Extension extension = new Extension();

        [Fact]
        public void TestAdd_2and3is5()
        {
            Assert.Equal(5, extension.Add(2, 3));
        }

        [Fact]
        public void TestAdd_1and4is5()
        {
            Assert.Equal(5, extension.Add(1, 4));
        }

        [Fact]
        public void TestMaxOfThree_First()
        {
            Assert.Equal(5, extension.MaxOfThree(5, 4, 3));
        }

        [Fact]
        public void TestMaxOfThree_Fhird()
        {
            Assert.Equal(5, extension.MaxOfThree(3, 4, 5));
        }

        [Fact]
        public void TestMedian_Four()
        {
            Assert.Equal(5, extension.Median(new List<int>() { 7, 5, 3, 5 }));
        }

        [Fact]
        public void TestMedian_Five()
        {
            Assert.Equal(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
        }

        [Fact]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Fact]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('u'));
        }

        [Fact]
        public void testTranslate_bemutatkozik()
        {
            Assert.Equal("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Fact]
        public void testTranslate_kolbice()
        {
            Assert.Equal("lavagovopuvus", extension.Translate("lagopus"));
        }




        [Fact]
        public void TestAddTwoInt()
        {
            int a = 3;
            int b = 4;
            int expectedOutput = 7;

            int actualOutput = extension.Add(a, b);

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void TestMaxAmongThree()
        {
            int a = 3;
            int b = 6;
            int c = 5;
            int expectedOutput = b;

            int actualOutput = extension.MaxOfThree(a, b, c);

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void TestMedian()
        {
            List<int> testlList = new List<int>{3, 6, 4, 12};
            int expectedOutput = 5;

            int actualOutput = extension.Median(testlList);

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void TestTranslation()
        {
            string testString = "uieudcc";
            string expectedOutput = "uvuivieveuvudcc";

            string actualOutput = extension.Translate(testString);

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
