using Tyuiu.SushchikIA.Sprint1.Task4.V10.Lib;
namespace Tyuiu.SushchikIA.Sprint1.Task4.V10.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(3.414, ds.Calculate(45), 0.001);
        }
    }
}
