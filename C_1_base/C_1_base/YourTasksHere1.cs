﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_base
{
    public static class YourTasksHere1
    {


        #region Задача 1
        /*
         * На вход подаются два катета прямоугольного тругольника требуется найти площадь этого тругольника
        */

        public static double SquerOfTrungle(uint a, uint b)
        {
            return (double) a * b / 2;
        }
        #endregion


        #region Задача 2
        /*
         * На вход подаются длины трех отрезков, верните true, если они могут образовать тругольник, в обратном случае верните false
         * 
         * Условие существования треугольника - a меньше или равно b + c, должно выполняться для любой a 
        */

        public static bool isTrungle(uint a, uint b, uint c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
                return true;
        }

        public static bool isTrungle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
                return true;
        }
        #endregion


        #region Задача 3
        /*
         * На вход подается два числа, если числа имеют одинаковые знаки, необходимо вывести сумму, иначе разность, взятую по модулю
        */

        public static int Arifmetika(int a, int b)
        {
            if (a * b > 0)
            {
                return a + b;
            }
            else
            {
                if (a < 0 && b > -a)
                    return a + b;
                else
                    return -a - b;
            }
        }
        #endregion


        #region Задача 4
        /*
         * На вход подается число, необходимо найти и вернуть факториал этого числа (гарантируется, что входное число больше или равно 1)
        */

        public static int Fuc(int a)
        {
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return sum;
        }
        #endregion


        #region Задача 5
        /*
         * На вход подается число n, необходимо создать массив длинной n и проинициализровать его значениями n, n-1 ... 1 (гарантируется, что n >= 1)
        */

        public static int[] ArrayCreate(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = n - i;
            }
            return arr;
        }
        #endregion


        #region Задача 6
        /*
         * На вход подается массив чисел, необходимо вернуть индекс первого вхождения наибольшего элемента массива
        */

        public static int MaxSearch(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            return max;
        }
        #endregion


        #region Задача 7
        /*
         * На вход подается массив чисел, необходимо вернуть его полную копию
        */

        public static int[] ArrayCopy(int[] array)
        {
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
        #endregion


        #region Задача 8
        /*
         * Реализуйте рекурсивную функцию нахождения чисел Фибоначи (a(n) = a(n-1) + a(n-2), где a(1) - 1, a(2) - 2)
        */

        public static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        #endregion


        #region Задача 9
        /*SS
         * На вход подается массив, необходимо найти наибольшее значение в нем (рекомендуется использовать функцию из задания 6),
         * а так же вернуть полную копию входного массива с помощью модификатора out (рекомендуется использовать функцию из задания 7)
        */

        public static int HardArray(int[] intput, out int[] output)
        {
            output = ArrayCopy(intput);
            return intput[MaxSearch(intput)];
        }
        #endregion


        #region Задача 10
        /*
         * Вы создаете боевую систему для компьютерной игры
         * Вам необходимо написать метод, который расчитывает результаты боя
         * На каждом ходу игроки наносят урон противнику равный их силе
         * Бой заканчивается, когда у одного из игроков (или у обоих) здоровье опуститься до 0 или ниже
        */

        public static void Fight(ref int health1, int power1, ref int health2, int power2)
        {
            while (health1 > 0 && health2 > 0)
            {
                health1 -= power2;
                health2 -= power1;
            }
        }
        #endregion
    }
}
