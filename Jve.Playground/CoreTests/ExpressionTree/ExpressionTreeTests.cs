using Core.Alignment;
using Core.ExpressionTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple = Core.Alignment.StepAlignmentConfiguration;

namespace CoreTests.AlignmentTests
{
    [TestClass]
    public class ExpressionTreeTests
    {
        [TestMethod]
        public void SimpleTest()
        {
            var literal = new Literal { Value = "1" };
            var literal2 = new Literal { Value = "2" };

            var constraint = new Constraint();
            var expression = new Expression();
            expression.Left = literal;
            expression.Right = literal2;
            
        }

    }
}
