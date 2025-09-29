using Tyuiu.SushchikIA.Sprint1.Task6.V16.Lib;

namespace Tyuiu.SushchikIA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckSpecSymbols("!!!eifje*??f?ifeoj!!!!"));
        }
    }
}
