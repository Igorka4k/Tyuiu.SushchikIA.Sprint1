﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SushchikIA.Sprint1.Task1.V8.Lib
{
    public class DataService : ISprint1Task1V8
    {
        public double Calculate(double a, double x)
        {

            return Math.Round((x * Math.PI) / a, 3);
        }
    }
}
