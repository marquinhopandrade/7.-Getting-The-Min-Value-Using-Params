using System;

namespace _7._Getting_The_Min_Value_Using_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(6, 4, 2, 8, 0, 1, 5); //7 valores
                                                  //Math.Min(3 , 2.5); Output: 2.5; -----> math.min funciona com int vs decimal
            Console.WriteLine("athe minimun is {0} : ", min);                                                  
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
    }
}
