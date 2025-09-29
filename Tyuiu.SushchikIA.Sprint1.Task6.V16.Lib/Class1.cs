using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.SushchikIA.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            bool flag = value.Contains('!') && value.Contains('?');
            return flag;
        }
    }
}
