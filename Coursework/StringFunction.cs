﻿using System;
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
            if (expression.HasErrors()) throw new Exception("Invalid function input");
        }

        /*
         * Возвращает значение функции в точке x
         * Выбрасывает исключение, если рассчет невозможен
         */
        public double EvaluateAt(double x)
        {
            expression.Parameters["x"] = x;
            return (double) expression.Evaluate();
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
