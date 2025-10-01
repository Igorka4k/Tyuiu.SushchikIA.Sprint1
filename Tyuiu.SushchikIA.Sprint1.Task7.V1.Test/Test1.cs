using Tyuiu.SushchikIA.Sprint1.Task7.V1.Lib;
namespace Tyuiu.SushchikIA.Sprint1.Task7.V1.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1.414, ds.Calculate(1, 2, 3));
        }
    }
}
