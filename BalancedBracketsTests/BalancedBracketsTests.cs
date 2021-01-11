using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        /* Possible Test cases
         * 
         * Positive
         * "[]"
         * "[Balanced]WithText"
         * "[[]]"
         * "Balance[With[Multi]ple]Brackets"
         * 
         * Negative
         * "]["
         * "["
         * "]"
         * "Unbalanced[WithText"
         * "Unbalanced[Multiple[With]Text"
         * "Unbalance[Multiple]With]Text"
         * 
         * Edge (positive cases on the edge)
         * ""
         * "Balanced"
         * "[[] [[]]]"
         * 
         */

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            //Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("") == true);
            string testInput = "";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = true;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TextWithoutBrakets()
        {
            string testInput = "Balanced";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = true;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            //Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]") == true);
            string testInput = "[]";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = true;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void OnlyOpenBracketReturnsFalse()
        {
            //Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[") == false);
            string testInput = "[";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = false;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void OnlyCloseBracketReturnsFalse()
        {
            //Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("]") == false);
            string testInput = "]";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = false;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void ReversedBracketsReturnsFalse()
        {
            //Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("][") == false);
            string testInput = "][";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = false;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TwoOpenBracketsReturnsFalse()
        {
            string testInput = "[Lau[nchCode";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = false;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TextWithOneBalancedPairReturnsTrue()
        {
            string testInput = "[LaunchCode]";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = true;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TextWithOneInternalBalancedPairReturnsTrue()
        {
            string testInput = "Launch[Code]";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = true;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TextWithOneBracketReturnsFalse()
        {
            string testInput = "[LaunchCode";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = false;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TextWithReversedBracketReturnsFalse()
        {
            string testInput = "Launch]Code[";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = false;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TextWithOneNestedBracketReturnsTrue()
        {
            string testInput = "[Lau[nch]Co]de";

            bool actualOutput = BalancedBrackets.HasBalancedBrackets(testInput);
            bool expectedOutput = true;

            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
