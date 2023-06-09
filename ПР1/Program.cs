using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР1
{
    class Program
    {
        #region Сортировка всех массивов
        static void SortByRows(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            int temp = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = temp;
                        }
                    }
                }
            }
        }

        static void SortByCols(int[,] arr, int m, int n)
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m - 1; i++)
                {
                    for (int k = i + 1; k < m; k++)
                    {
                        if (arr[i, j] > arr[k, j])
                        {
                            int temp = arr[i, j];
                            arr[i, j] = arr[k, j];
                            arr[k, j] = temp;
                        }
                    }
                }
            }
        }
        #endregion

        #region ПР 1.1

        //static void Main()
        //{
        //    Random rand = new Random();

        //    int m = rand.Next(3, 7), n = m;
        //    int[,] arr = new int[m, n];
        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            arr[i, j] = rand.Next(10);
        //        }
        //    }

        //    Console.WriteLine("Исходный массив:");
        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            Console.Write(arr[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //    SortByRows(arr, m, n);
        //    Console.WriteLine("\nМассив отсортированный построчно:");
        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            Console.Write(arr[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //    SortByCols(arr, m, n);
        //    Console.WriteLine("\nМассив отсортированный по столбцам:");
        //    for (int i = 0; i < m; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            Console.Write(arr[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.ReadKey();
        //}
        #endregion
        #region ПР 1.2
        //static void Main()
        //{
        //    int[,] arr = new int[3, 3];
        //    Random rand = new Random();
        //    int num = 2;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            arr[i, j] = num + rand.Next(8); // 
        //        }
        //    }

        //    // Вывод массива на экран
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(arr[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.ReadKey();
        //}
        #endregion
        #region ПР 1.3

        //static void Main()
        //{
        //    string[] toppings = { "Говяжий котлетос", "Куриный котлетос", "бЭкон", "Сырок", "Капуста", "Помидорка", "Ончоуз", "Соленый огурец", "Кетчуп", "Чесночный соус", "Кетчунез" };
        //    int numToppings = toppings.Length;

        //    Console.WriteLine("Ты пришел в бургерную...");

        //    // Формирование случайного рецепта
        //    Random rand = new Random();
        //    int numPatties = rand.Next(3, 10);
        //    int numVegetables = rand.Next(2, 5);
        //    int numSauces = rand.Next(1, 3);

        //    // Вывод рецепта на экран
        //    Console.WriteLine("Рецепт вашего Чмобургера:");
        //    Console.WriteLine(numPatties + " говяжьих яиц");

        //    for (int i = 0; i < numVegetables; i++)
        //    {
        //        int toppingIndex = rand.Next(numToppings);
        //        if (toppings[toppingIndex] == "Говяжий котлетос" || toppings[toppingIndex] == "Куриный котлетос")
        //        {
        //            i--;
        //        }
        //        else
        //        {
        //            Console.WriteLine(toppings[toppingIndex]);
        //        }
        //    }

        //    for (int i = 0; i < numSauces; i++)
        //    {
        //        int toppingIndex = rand.Next(numToppings);
        //        if (toppings[toppingIndex] == "Говяжий котлетос" || toppings[toppingIndex] == "Куриный котлетос")
        //        {
        //            i--;
        //        }
        //        else if (toppings[toppingIndex] == "Кетчуп" || toppings[toppingIndex] == "Чесночный соус" || toppings[toppingIndex] == "Кетчунез")
        //        {
        //            if (i > 0)
        //            {
        //                i--;
        //            }
        //            else
        //            {
        //                Console.WriteLine(toppings[toppingIndex]);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine(toppings[toppingIndex]);
        //        }
        //    }

        //    Console.WriteLine("\nЖри и уходи урод");
        //    Console.ReadKey();
        //}
        #endregion
        #region ПР 1.4
        static void Main()
        {

            string[] people = { "Том круз", "Меллстрой", "Уоллтер",
                                "Райан Гослинг", "Шастун", "Соболев" };
            Random rand = new Random();
            int numsName = rand.Next(people.Length);
            Console.WriteLine("Кто будет дежурить:");

            Console.WriteLine(people[numsName]);
            Console.ReadKey();
        }
        #endregion
    }
}
