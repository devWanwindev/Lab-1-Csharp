using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int reload = 1;
            while (reload == 1)
            {

                Console.Write(" 1 - Методы\r\n 2 - Условия\r\n 3 - Циклы\r\n 4 - Массивы\r\n Выбирите задание: ");
                int zadanie = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Program program = new Program();

                switch (zadanie)
                {
                    case 1:
                        Console.WriteLine("----------/ Задание_1 - Методы /----------\n");

                        Console.Write(" 1 - Дробная часть.\r\n 3 - Букву в число.\r\n 5 - Двузначное.\r\n 7 - Диапазон.\r\n 9 - Равенство.\r\n Выбирите задание: ");
                        int meto1 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        switch (meto1)
                        {
                            case 1:
                                Console.WriteLine("----| Дробная часть |----");
                                Console.WriteLine("Введите вещественное число (через запятую): ");
                                try
                                {
                                    double number = Convert.ToDouble(Console.ReadLine());
                                    double result = program.fraction(number);
                                    Console.WriteLine("Дробная часть числа: " + result);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("----| Букву в число |----");
                                Console.WriteLine("Введите одну букву: ");
                                string s3 = Console.ReadLine();
                                if (s3.Length == 1)
                                {
                                    char x3 = Convert.ToChar(s3);
                                    int res3 = program.charToNum(x3);
                                    Console.WriteLine("Преобразование: " + x3 + " -> " + res3);
                                }
                                else
                                {
                                    Console.WriteLine("Вы ввели больше чем одну букву");
                                }
                                break;
                            case 5:
                                Console.WriteLine("----| Двузначное число |----");
                                Console.WriteLine("Введите двузначное число: ");
                                try
                                {
                                    int number = Convert.ToInt32(Console.ReadLine());
                                    bool result = program.is2Digits(number);
                                    if (result)
                                    {
                                        Console.WriteLine("True");
                                    }
                                    else { Console.WriteLine("False"); }

                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break

                            ;
                            case 7:
                                Console.WriteLine("----| Диапозон |----");
                                Console.WriteLine("Введите диапозон a и b и число num: ");
                                try
                                {
                                    Console.Write("a =: ");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("b =: ");
                                    int b = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("num =: ");
                                    int num = Convert.ToInt32(Console.ReadLine());
                                    bool result = program.isInRange(a, b, num);
                                    if (result)
                                    {
                                        Console.WriteLine("True");
                                    }
                                    else { Console.WriteLine("False"); }

                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 9:
                                Console.WriteLine("----| Равенство |----");
                                Console.WriteLine("Введите три равных числа: ");
                                try
                                {
                                    Console.Write("a =: ");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("b =: ");
                                    int b = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("с =: ");
                                    int с = Convert.ToInt32(Console.ReadLine());
                                    bool result = program.isEqual(a, b, с);
                                    if (result)
                                    {
                                        Console.WriteLine("True");
                                    }
                                    else { Console.WriteLine("False"); }

                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }

                                break;
                            default:
                                Console.WriteLine("Задание отсутсвует");
                                break;
                        }
                        break; // Методы
                    case 2:
                        Console.WriteLine("----------/ Задание_2 - Условия /----------\n");

                        Console.Write(" 1 - Модуль числа. \r\n 3 - Тридцать пять. \r\n 5 - Тройной максимум. \r\n 7 - Двойная сумма. \r\n 9 - День недели. \r\n Выбирите задание: ");
                        int meto2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (meto2)
                        {
                            case 1:
                                Console.WriteLine("----| Модуль числа. |----");
                                try
                                {
                                    Console.Write("Напишите число (положительное или отрицательное): ");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    int result = program.abs(a);
                                    Console.WriteLine("Модуль числа: " + result);

                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("----| Тридцать пять. |----");
                                try
                                {
                                    Console.Write("Напишите число: ");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    bool result = program.is35(a);
                                    if (result)
                                    {
                                        Console.WriteLine("True");
                                    }
                                    else
                                    {
                                        Console.WriteLine("False");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 5:
                                Console.WriteLine("----| Тройной максимум. |----");
                                Console.WriteLine("Введите три числа: ");
                                try
                                {
                                    Console.Write("x =: ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("y =: ");
                                    int y = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("z =: ");
                                    int z = Convert.ToInt32(Console.ReadLine());
                                    int result = program.max3(x, y, z);
                                    Console.WriteLine("Максимальное число: " + result);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 7:
                                Console.WriteLine("----| Двойная сумма |----");
                                Console.WriteLine("Введите два числа: ");
                                try
                                {
                                    Console.Write("x =: ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("y =: ");
                                    int y = Convert.ToInt32(Console.ReadLine());
                                    int result = program.sum2(x, y);
                                    Console.WriteLine("Ответ: " + result);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 9:
                                Console.WriteLine("----| День недели. |----");
                                Console.WriteLine("Введите число: ");
                                try
                                {
                                    Console.Write("x =: ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    string result = program.day(x);
                                    Console.WriteLine("День недели: " + result);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            default:
                                Console.WriteLine("Задание отсутсвует");
                                break;
                        }
                        break; // Условия
                    case 3:
                        Console.WriteLine("----------/ Задание_3 - Циклы /----------\n");

                        Console.Write(" 1 - Числа подряд. \r\n 3 - Четные числа.  \r\n 5 - Длина числа. \r\n 7 - Квадрат. \r\n 9 - Правый треугольник \r\n Выбирите задание: ");
                        int meto3 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (meto3)
                        {
                            case 1:
                                
                                Console.WriteLine("----| Числа подряд. |----");
                                Console.WriteLine("Введите число: ");
                                try
                                {
                                    Console.Write("x =: ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    string result = program.listNums(x);
                                    Console.WriteLine("Числа: " + result);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;

                            case 3:
                                Console.WriteLine("----| Четные числа. |----");
                                Console.WriteLine("Введите число: ");
                                try
                                {
                                    Console.Write("x =: ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    string result = program.chet(x);
                                    Console.WriteLine("Четные числа: " + result);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 5:
                                Console.WriteLine("----| Длина числа. |----");
                                Console.WriteLine("Введите число: ");
                                try
                                {
                                    Console.Write("x =: ");
                                    long x = Convert.ToInt64(Console.ReadLine());
                                    int result = program.numLen(x);
                                    Console.WriteLine("Длинна числа: " + result);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 7:
                                Console.WriteLine("----| Квадрат. |----");
                                Console.WriteLine("Введите число: ");
                                try
                                {
                                    Console.Write("x =: ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    program.square(x);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 9:
                                Console.WriteLine("----| Правый треугольник |----");
                                Console.WriteLine("Введите число: ");
                                try
                                {
                                    Console.Write("x =: ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    program.rightTriangle(x);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            default:
                                Console.WriteLine("Задание отсутсвует");
                                break;
                        }
                        break;// Циклы
                    case 4:
                        Console.WriteLine("Задание_4 - Массивы");
                        Console.Write(" 1 - Поиск первого значения. \r\n 3 - Поиск максимального. \r\n 5 - Добавление массива в массив. \r\n 7 - Возвратный реверс. \r\n 9 - Все вхождения. \r\n Выбирите задание: ");
                        int meto4 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (meto4)
                        {
                            case 1:
                                
                                Console.WriteLine("----| Поиск первого значения. |----");
                                Console.WriteLine("Введите кол-во элементов в массиве и число x: ");
                                try
                                {
                                    Console.Write("Кол-во элементов =: ");
                                    int arr_size = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("x =: ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    
                                    int[] arr = new int[arr_size];

                                    for (int i = 0; i < arr_size; i++)
                                    {
                                        arr[i] = rnd.Next(0, 11);
                                        Console.Write(arr[i] + " ");
                                    }
                                    Console.WriteLine();

                                    int result = program.findFirst(arr, x);
                                    Console.WriteLine("Элемент: " + result);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 3:
                                Console.WriteLine("----| Поиск максимального. |----");
                                Console.WriteLine("Введите кол-во элементов в массиве: ");
                                try
                                {
                                    Console.Write("Кол-во элементов =: ");
                                    int arr_size = Convert.ToInt32(Console.ReadLine());

                                    int[] arr = new int[arr_size];

                                    for (int i = 0; i < arr_size; i++)
                                    {
                                        arr[i] = rnd.Next(-10, 10);
                                        Console.Write(arr[i] + " ");
                                    }

                                    Console.WriteLine();

                                    int result = program.maxAbs(arr);
                                    Console.WriteLine("Максимальный элемент: " + result);
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 5:
                                Console.WriteLine("----| Добавление массива в массив. |----");
                                try
                                {
                                    Console.WriteLine("Введите кол-во элементов в массиве номер 1: ");
                                    int arr_size_1 = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Введите кол-во элементов в массиве номер 2: ");
                                    int arr_size_2 = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Введите число: ");
                                    int pos = Convert.ToInt32(Console.ReadLine());

                                    int[] arr1 = new int[arr_size_1];

                                    Console.Write("Массив 1: ");
                                    for (int i = 0; i < arr_size_1; i++)
                                    {
                                        arr1[i] = rnd.Next(0, 10);
                                        Console.Write(arr1[i] + " ");
                                    }

                                    Console.WriteLine();

                                    int[] arr2 = new int[arr_size_2];

                                    Console.Write("Массив 2: ");
                                    for (int i = 0; i < arr_size_2; i++)
                                    {
                                        arr2[i] = rnd.Next(0, 10);
                                        Console.Write(arr2[i] + " ");
                                    }

                                    Console.WriteLine();

                                    int[] result = program.add(arr1, arr2, pos);


                                    Console.WriteLine("Совмещенный массив: ");

                                    for (int i = 0; i < result.Length; i++)
                                    {
                                        Console.Write(result[i] + " ");
                                    }

                                    Console.WriteLine();
                                    
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }

                                break;
                            case 7:
                                Console.WriteLine("----| Возвратный реверс. |----");
                                Console.WriteLine("Введите кол-во элементов в массиве: ");
                                try
                                {
                                    Console.Write("Кол-во элементов =: ");
                                    int arr_size = Convert.ToInt32(Console.ReadLine());

                                    int[] arr = new int[arr_size];

                                    for (int i = 0; i < arr_size; i++)
                                    {
                                        arr[i] = rnd.Next(0, 10);
                                        Console.Write(arr[i] + " ");
                                    }

                                    Console.WriteLine();

                                    int[] result = program.reverseBack(arr);
                                    Console.WriteLine("Перевернутый массив: ");

                                    for (int i = 0; i < result.Length; i++)
                                    {
                                        Console.Write(result[i] + " ");
                                    }

                                    Console.WriteLine();
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                            case 9:
                                Console.WriteLine("----| Возвратный реверс. |----");
                                try
                                {
                                    Console.Write("Кол-во элементов =: ");
                                    int arr_size = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Какое число ищем? = : ");
                                    int x = Convert.ToInt32(Console.ReadLine());
                                    int[] arr = new int[arr_size];

                                    for (int i = 0; i < arr_size; i++)
                                    {
                                        arr[i] = rnd.Next(0, 10);
                                        Console.Write(arr[i] + " ");
                                    }

                                    Console.WriteLine();

                                    int[] result = program.findAll(arr, x);
                                    Console.WriteLine("Индексы найденного числа: ");

                                    for (int i = 0; i < result.Length; i++)
                                    {
                                        Console.Write(result[i] + " ");
                                    }

                                    Console.WriteLine();
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Некорректные данные. Введите число в правильном формате.");
                                }
                                break;
                        }
                                break; // Массивы
                    default:
                        Console.WriteLine("Задание отсутсвует");
                        break;
                }

                Console.WriteLine("\n Введите 1 если хотите начать с начала: ");
                reload = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }



        public double fraction(double x)
        {
            return x - (int)x;
        }

        public int charToNum(char x)
        {
            return x - '0';
        }

        public bool is2Digits(int x)
        {
            return x >= 10 && x <= 99;
        }

        public bool isInRange(int a, int b, int num)
        {
            if ((num > a && num < b) || (num < a && num > b)) return true;
            else return false;
        }

        public bool isEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }

        public int abs(int x)
        {
            if (x < 0)
            {
                return -x;
            }
            return x;
        }

        public bool is35(int x)
        {
            return (x % 3 == 0 || x % 5 == 0) && !(x % 3 == 0 && x % 5 == 0);
        }

        public int max3(int x, int y, int z)
        {
            int max = x;
            if (y > max) max = y;
            if (z > max) max = z;
            return max;
        }

        public int sum2(int x, int y)
        {
            int sum = x + y;
            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }
            else
            {
                return sum;
            }
        }

        public String day(int x)
        {
            switch (x)
            {
                case 1: return "понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пятница";
                case 6: return "суббота";
                case 7: return "воскресенье";
                default: return "это не день недели";
            }
        }

        public String listNums(int x)
        {
            String result = "";
            for (int i = 0; i <= x; i++)
            {
                result = result + Convert.ToString(i) + " ";
            }
            return result;
        }

        public String chet(int x)
        {
            String result = "";
            for (int i = 0; i <= x; i += 2)
            {
                result = result + Convert.ToString(i) + " ";
            }
            return result;
        }

        public int numLen(long x)
        {
            int cnt = 0;
            while (x != 0)
            {
                cnt++;
                x /= 10;
            }
            return cnt;
        }

        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                for (int j = 0 ; j < x-i ; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        public int maxAbs(int[] arr)
        {
            int max = 0;
            int pos = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                        pos = i;
                    }
                }
                else
                {
                    if (max < -arr[i])
                    {
                        max = -arr[i];
                        pos = i;
                    }
                }
            }
            return arr[pos];
        }

        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] res = new int[arr.Length + ins.Length];

            int k = 0;
            for (int i = 0; i < arr.Length + ins.Length; i++)
            {   
                if (i == pos)
                {
                    for (int j = 0; j < ins.Length; j++)
                    {
                        res[i] = ins[j];
                        i++;
                    }
                }
                
                res[i] = arr[k];
                k++;
            }

            return res;
        }

        public int[] reverseBack(int[] arr)
        {
            int[] res = new int[arr.Length];
            for (int i = 0;  i < arr.Length; i++)
            {
                res[i] = arr[arr.Length - i - 1];
            }
            return res;
        }

        public int[] findAll(int[] arr, int x)
        {
            int cnt = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == x)
                {
                    cnt++;
                }
            }

            int[] res = new int[cnt];
            int k = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == x)
                {
                    res[k] = i;
                    k++;
                }
            }

            return res;
        }

    }
}

