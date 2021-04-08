using System;
using NCalc;
using static Coursework.RootFinder;

namespace Coursework
{
    /*
     * Позволяет преобразовывать строку в математическую 
     * функцию с одним неизвестным вещественным параметром x
     * и вычислять ее корень
     */
    class StringFunction
    {

        private readonly Expression expression;

        public StringFunction(string function)
        {
            expression = new Expression(function);
            if (expression.HasErrors()) throw new Exception("Неверная запись функции");
            expression.Parameters["x"] = 0; //Проверяем работоспособность функции
            try
            {
                expression.Evaluate();
            } catch(Exception)
            {
                throw new Exception("Неверная запись функции");
            }
        }

        /*
         * Возвращает значение функции в точке x
         * Выбрасывает исключение, если рассчет невозможен
         */
        public double EvaluateAt(double x)
        {
            expression.Parameters["x"] = x;
            double result = (double) expression.Evaluate();
            if (Double.IsNaN(result) || Double.IsInfinity(result)) 
                throw new EvaluationException("Невозможно рассчитать значение функции в точке x = " + x);
            return result;
        }

        /*
         * Возвращает делегат Function из класса RootFinder
         * со ссылкой на метод EvaluateAt
         */
        public Function AsFunction()
        {
            return EvaluateAt;
        }

    }
}
