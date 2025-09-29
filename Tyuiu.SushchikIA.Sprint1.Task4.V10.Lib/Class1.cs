using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SushchikIA.Sprint1.Task4.V10.Lib
{
    public class DataService : ISprint1Task4V10
    {
        public double Calculate(double a)
        {

            return Math.Round((1 + Math.Cos(a)) / (Math.Sin(a) * Math.Sin(a)), 3);
        }
    }
}
