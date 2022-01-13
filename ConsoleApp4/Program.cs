using System;

namespace ConsoleApp4
{
    internal class Program
    {
        private static void Main()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            Console.Write("Write size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            int quanOfEvenValues = 0;
            int quanOfOddValues = 0;
            char[] evenValues;
            char[] oddValues;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 27);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    quanOfEvenValues++;
                }
                else
                {
                    quanOfOddValues++;
                }
            }

            evenValues = new char[quanOfEvenValues];
            oddValues = new char[quanOfOddValues];

            int a = 0;
            int b = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (alphabet[array[i] - 1] == 'd' || alphabet[array[i] - 1] == 'h' || alphabet[array[i] - 1] == 'j')
                    {
                        evenValues[a] = Convert.ToChar(alphabet[array[i] - 1].ToString().ToUpper());
                        a++;
                    }
                    else
                    {
                        evenValues[a] = alphabet[array[i] - 1];
                        a++;
                    }
                }
                else
                {
                    if (alphabet[array[i] - 1] == 'a' || alphabet[array[i] - 1] == 'e' || alphabet[array[i] - 1] == 'i')
                    {
                        oddValues[b] = Convert.ToChar(alphabet[array[i] - 1].ToString().ToUpper());
                        b++;
                    }
                    else
                    {
                        oddValues[b] = alphabet[array[i] - 1];
                        b++;
                    }
                }
            }

            int evenArrayUpperLetters = 0;
            int oddArrayUpperLetters = 0;

            for (int i = 0; i < evenValues.Length; i++)
            {
                if (evenValues[i].ToString() == evenValues[i].ToString().ToUpper())
                {
                    evenArrayUpperLetters++;
                }
            }

            for (int i = 0; i < oddValues.Length; i++)
            {
                if (oddValues[i].ToString() == oddValues[i].ToString().ToUpper())
                {
                    oddArrayUpperLetters++;
                }
            }

            if (evenArrayUpperLetters > oddArrayUpperLetters)
            {
                Console.WriteLine("В массиве четных чисел букв в верхнем регистре больше");
            }
            else if (evenArrayUpperLetters < oddArrayUpperLetters)
            {
                Console.WriteLine("В массиве нечетных чисел букв в верхнем регистре больше");
            }
            else
            {
                Console.WriteLine("Одинаковое кол-во букв в верхнем регистре");
            }

            Console.Write("Массив с буквами с четным порядковым номером: ");
            for (int i = 0; i < evenValues.Length; i++)
            {
                Console.Write(evenValues[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Массив с буквами с нечетным порядковым номером: ");
            for (int i = 0; i < oddValues.Length; i++)
            {
                Console.Write(oddValues[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
