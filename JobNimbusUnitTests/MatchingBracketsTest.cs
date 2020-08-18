using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobNimbusAssessment;

namespace JobNimbusUnitTests
{
    [TestClass]
    public class MatchingBracketsTest
    {
        [TestMethod]
        public void Should_Return_True_if_macthing_Test1()
        {
            string test = "{}";
            bool expected = true;

            MatchingBrackets mb = new MatchingBrackets();
            var actual1 = mb.HasMatchingBrackets_Approach1(test);
            var actual2 = mb.HasMatchingBrackets_Approach2(test);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void Should_Return_True_if_macthing_Test2()
        {
            string test = "{{Mahima}}{}{{}}";
            bool expected = true;

            MatchingBrackets mb = new MatchingBrackets();
            var actual1 = mb.HasMatchingBrackets_Approach1(test);
            var actual2 = mb.HasMatchingBrackets_Approach2(test);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void Should_Return_True_if_macthing_Test3()
        {
            string test = "{{{{}}}}{}{}{{}}";
            bool expected = true;

            MatchingBrackets mb = new MatchingBrackets();
            var actual1 = mb.HasMatchingBrackets_Approach1(test);
            var actual2 = mb.HasMatchingBrackets_Approach2(test);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void Should_Return_False_if_not_macthing_Test1()
        {
            string test = "{{}";
            bool expected = false;

            MatchingBrackets mb = new MatchingBrackets();
            var actual1 = mb.HasMatchingBrackets_Approach1(test);
            var actual2 = mb.HasMatchingBrackets_Approach2(test);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void Should_Return_False_if_not_macthing_Test2()
        {
            string test = "}{";
            bool expected = false;

            MatchingBrackets mb = new MatchingBrackets();
            //var actual = mb.HasMatchingBrackets(test);
            var actual1 = mb.HasMatchingBrackets_Approach1(test);
            var actual2 = mb.HasMatchingBrackets_Approach2(test);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void Should_Return_False_if_not_macthing_Test3()
        {
            string test = "{{abcd}}}}}";
            bool expected = false;

            MatchingBrackets mb = new MatchingBrackets();
            var actual1 = mb.HasMatchingBrackets_Approach1(test);
            var actual2 = mb.HasMatchingBrackets_Approach2(test);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void Should_Return_False_if_not_macthing_Test4()
        {
            string test = "}}}}{{{{";
            bool expected = false;

            MatchingBrackets mb = new MatchingBrackets();
            var actual1 = mb.HasMatchingBrackets_Approach1(test);
            var actual2 = mb.HasMatchingBrackets_Approach2(test);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }

        [TestMethod]
        public void Should_Return_True_if_empty_Test()
        {
            string test = "";
            bool expected = true;

            MatchingBrackets mb = new MatchingBrackets();
            var actual1 = mb.HasMatchingBrackets_Approach1(test);
            var actual2 = mb.HasMatchingBrackets_Approach2(test);

            // Assert
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
        }
    }
}
