using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SushchikIA.Sprint1.Task7.V1.Lib
{
    public class DataService : ISprint1Task7V1
    {
        public double Calculate(double a, double b, double c)
        {
            return Math.Round(((b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c)) / (2 * a)) - a * a * a * c + Math.Sqrt(b), 3);
        }
    }
}
