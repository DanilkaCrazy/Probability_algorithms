using System;


namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomValue randomValue = new RandomValue(0, 1);
            double x = randomValue.GenerateRandomValue();
            double y = randomValue.GenerateRandomValue();
            double z = randomValue.Add(x, y); // складываем
            double w = randomValue.Subtract(x, y); // вычитаем

            Console.WriteLine("Сгенерированные числа: {0} и {1}", x, y);
            Console.WriteLine("Результат сложения: {0}", z);
            Console.WriteLine("Результат вычитания: {0}", w);
        }

        public class RandomValue
        {
            private Random _random = new Random();

            private readonly double _minValue;
            private readonly double _maxValue;

            public RandomValue(double minValue, double maxValue)
            {
                _minValue = minValue;
                _maxValue = maxValue;
            }

            public double GenerateRandomValue()
            {
                return _random.NextDouble() * (_maxValue - _minValue) + _minValue;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }

            public double Subtract(double a, double b)
            {
                return a - b;
            }
        }
    }
}
