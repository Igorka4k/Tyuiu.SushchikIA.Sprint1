using Tyuiu.SushchikIA.Sprint1.Review.V29.Lib;

namespace Tyuiu.SushchikIA.Sprint1.Review.V29.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(2.072, ds.Calculate(2, 4));
        }
    }
}
