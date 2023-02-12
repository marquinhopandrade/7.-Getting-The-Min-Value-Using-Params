using System;

namespace _7._Getting_The_Min_Value_Using_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(6, 4, 2, 8, 0, 1, 5, -30, -15, -10); //7 valores
            float min2 = MinV3(3.3f, -5.5f, 110.9f, 50.6f, -19.5f);
            //Math.Min(3 , 2.5); Output: 2.5; -----> math.min funciona com int vs decimal
            Console.WriteLine("The minimum int is: {0} ", min);
            Console.WriteLine("The minimum float is: {0} ", min2);
        }
        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue; //Usando o MaxValue, agora eu posso comparar o numero que eu vou passar com o mínimo
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
        public static float MinV3(params float[] numbers)
        {
            float min = float.MaxValue; //Usando o MaxValue, agora eu posso comparar o numero que eu vou passar com o mínimo
            foreach (float number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
}
