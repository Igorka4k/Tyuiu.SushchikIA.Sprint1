using Tyuiu.SushchikIA.Sprint1.Task1.V8.Lib;
namespace Tyuiu.SushchikIA.Sprint1.Task1.V8.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual((3 * Math.PI) / 1, ds.Calculate(1, 3));
        }
    }
}
