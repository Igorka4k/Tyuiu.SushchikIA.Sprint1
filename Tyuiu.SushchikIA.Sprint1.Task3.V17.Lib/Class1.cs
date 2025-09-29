using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SushchikIA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            double fractional = Math.Abs(number - (int)number);
            bool hasZero = false;

            for (int i = 0; i < 3; i++)
            {
                fractional *= 10; // Сдвигаем запятую
                int digit = (int)fractional % 10; // Получаем текущую цифру

                if (digit == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            return hasZero;
        }
    }
}
