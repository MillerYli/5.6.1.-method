using System;

namespace mynamespase
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int number = 0;
            for (int i = 0; i < result.Length; i++)
            { 
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        number = result[i];
                        result[i] = result[j];
                        result[j] = number;
                    }
            }
            

            for(int k = 0; k < result.Length; k++)
            {
                Console.Write(result[k] + " ");
            }

            return result;
        }
        public static void Main(string[] args) 
        { 
            GetArrayFromConsole();
            
        }
    }
}
