using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <remark>
    /// Этот класс генерирует простые числа, не превышающие заданного
    /// пользователем порога. В качестве алгоритма используется решето
    /// Эратосфена.
    /// Сам алгоритм прост. Пусть дан массив целых чисел, начинающийся
    /// с 2. Вычеркиваем все кратные 2. Находим первое невычеркнутое
    /// число и вычеркиваем все его кратные. Повторяем, пока не
    /// дойдем до квадратного корня из максимального значения.
    /// </remark>
    public class GeneratePrimes
    {
        /// <summary>
        /// Генерируем массив простых чисел 
        /// </summary>
        /// <param name="maxValue"> Верхний порог</param>
        /// <returns></returns>
        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            // единственный допустимый случай
            if (maxValue >= 2)
            {
                // Объявления
                // Размер массива
                int s = maxValue + 1;
                bool[] f = new bool[s];
                int i;
                // инициализировать значения массива - true
                for (i = 0; i < s; i++)
                {
                    f[i] = true;
                }
                // исключить заведомо непростые числа 
                f[0] = f[1] = false;

                // решето
                int j;
                for (i = 0; i < Math.Sqrt(s)+1; i++)
                {
                    // если i не вычеркнуто - вычернуть его кратные
                    if (f[i])
                    {
                        for (j = 2 * i; j < s; j+=i)
                        {
                            f[j] = false; // кратное - не простое число
                        }
                    }
                }

                // сколько оказалось простых чисел?
                int count = 0;
                for (i = 0; i < s; i++)
                {
                    if (f[i])
                    {
                        // увеличить счётчик
                        count++; 
                    }
                }

                int[] primes = new int[count];

                // поместить простые числа в результирующий массив
                for (i = 0, j = 0; i < s; i++)
                {
                    if (f[i])
                    {
                        primes[j++] = i;
                    }
                    // вернуть простые числа
                }
                return primes;
            }
            else
            {
                // maxValue < 2
                return new int[0];
                // если входные данные не корректы - возвратить
                // пустой массив
            }
        }
    }
}
