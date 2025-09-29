using Tyuiu.SushchikIA.Sprint1.Task3.V17.Lib;
namespace Tyuiu.SushchikIA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.ZeroCheck(3.103));
        }
    }
}
