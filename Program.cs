using System;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        private const int V = 100;

        static void Main(string[] args)
        {
            var vector = new double[100];
            var rand = new Random();
            // заполняем массив случайными значениями
            for (var i = 0; i < vector.Length; i++)
                vector[i] = rand.NextDouble() * 100;
            // находим случайный индекс
            var indexForSqrt = rand.Next(vector.Length);
            // находим квадратный корень
            var sqrtValue = Math.Sqrt(vector[indexForSqrt]);
            Console.WriteLine(@"Квадратный корень из vector[{0}]={1} равен: {2}",
                                indexForSqrt, vector[indexForSqrt], sqrtValue);
            // находим первый случайный индекс
            var indexOneForAverage = rand.Next(vector.Length);
            // находим второй случайный индекс
            var indexTwoForAverage = rand.Next(vector.Length);
            // находим усреднение
            var averageValue = (vector[indexOneForAverage] + vector[indexTwoForAverage]) / 2;
            Console.WriteLine(@"Среднее арифметическое vector[{0}]={1} и vector[{2}]={3} равно: {4}",
                indexOneForAverage, vector[indexOneForAverage], indexTwoForAverage, vector[indexTwoForAverage], averageValue);
        }
    }
}
