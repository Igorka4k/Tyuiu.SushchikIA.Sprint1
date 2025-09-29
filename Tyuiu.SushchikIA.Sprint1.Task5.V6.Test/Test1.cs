using Tyuiu.SushchikIA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.SushchikIA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(6, ds.Calculate(13));
        }
    }
}
