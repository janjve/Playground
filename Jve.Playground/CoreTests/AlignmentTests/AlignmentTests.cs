using Core.Alignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple = Core.Alignment.StepAlignmentConfiguration;

namespace CoreTests.AlignmentTests
{
    [TestClass]
    public class AlignmentTests
    {
        [TestMethod]
        public void SimpleTest()
        {
            const string string1 = "test";
            const string string2 = "tess";
            var sut = new Alignment(Simple.Alpha, Simple.Delta, Simple.Max);
            
            var result = sut.Evaluate(string1, string2);
            var resultReverse = sut.Evaluate(string2, string1);

            Assert.AreEqual(3, result);
            Assert.AreEqual(3, resultReverse);
        }

        [TestMethod]
        public void EqualTest()
        {
            const string string1 = "test";
            const string string2 = "test";
            var sut = new Alignment(Simple.Alpha, Simple.Delta, Simple.Max);

            var result = sut.Evaluate(string1, string2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void UnevenLengthTest()
        {
            const string string1 = "test";
            const string string2 = "test2";
            var sut = new Alignment(Simple.Alpha, Simple.Delta, Simple.Max);

            var result = sut.Evaluate(string1, string2);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void EmptyTest()
        {
            const string string1 = "test";
            const string string2 = "";
            var sut = new Alignment(Simple.Alpha, Simple.Delta, Simple.Max);

            var result = sut.Evaluate(string1, string2);

            Assert.AreEqual(-4, result);
        }
    }
}
