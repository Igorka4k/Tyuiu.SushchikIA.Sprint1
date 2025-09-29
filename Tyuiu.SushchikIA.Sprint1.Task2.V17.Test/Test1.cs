using Tyuiu.SushchikIA.Sprint1.Task2.V17.Lib;
namespace Tyuiu.SushchikIA.Sprint1.Task2.V17.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValueExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(6, ds.ConvertMinutesToHours(360));
        }
    }
}
