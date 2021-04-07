using NCalc;
using System;

namespace Coursework
{
    class RootFinder
    {

        public delegate double Function(double x);

        //Рекурсивно находим корень функции методом деления отрезка пополам
        public static double FindRoot(double a, double b, double eps, Function function)
        {
            if (a >= b) throw new Exception("Задан неверный отрезок, A должно быть меньше B");
            double center = (a + b) / 2; //Середина отрезка
            //Если длина промежутка AB меньше эпсилон, значит мы
            //максимально приблизились к корню функции и можно выдавать результат
            if(Math.Abs(b - a) <= eps)
            {
                return center; //За результат берем точку в середине отрезка AB
            }
            try
            {
                //Находим значения функции на границе отрезка и в его центре
                double aValue = function(a);
                double bValue = function(b);
                double centerValue = function(center);
                bool isIncreasing = aValue < bValue;
                //Находим половину промежутка, в которой будем продолжать искать корень
                if(isIncreasing ? 
                    aValue <= 0 && centerValue >= 0 : 
                    aValue >= 0 && centerValue <= 0) //Корень лежит в левом промежутке
                {
                    return FindRoot(a, center, eps, function);
                }
                if(isIncreasing ?
                    centerValue <= 0 && bValue >= 0 :
                    centerValue >= 0 && bValue <= 0) //Корень лежит в правом промежутке
                {
                    return FindRoot(center, b, eps, function);
                }
                throw new Exception("Нет корня на данном промежутке");
            } catch(EvaluationException)
            {
                throw new Exception("На указанном промежутке функция имеет разрывы или не существует");
            }
            throw new Exception("При нахождении корня произошла ошибка");
        }

    }
}
