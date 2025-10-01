using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SushchikIA.Sprint1.Review.V29.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(x - (Math.Cos(Math.Pow(x, 3)) / (x * y - 3)) + (Math.Sin(Math.Pow(x, 5)) / (x * y + 5)), 3);
            //return Math.Round(x - (Math.Pow(Math.Cos(x), 3) / (x * y - 3)) + (Math.Pow(Math.Sin(x), 5) / (x * y + 5)), 3);
            //return Math.Round(x - ((Math.Cos(x) * Math.Cos(x) * Math.Cos(x)) / (x * y - 3)) + ((Math.Sin(x) * Math.Sin(x) * Math.Sin(x) * Math.Sin(x) * Math.Sin(x)) / (x * y + 5)), 3);


        }

    }
}
