using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SushchikIA.Sprint1.Task4.V10.Lib
{
    public class DataService : ISprint1Task4V10
    {
        public double Calculate(double a)
        {
            double alpha = 45;
            double alphaRad = alpha * Math.PI / 180;

            // Act
            double result = (1 + Math.Cos(alphaRad)) / Math.Pow(Math.Sin(alphaRad), 2);
            return result;
        }
    }
}
