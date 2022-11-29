
public class Homework_05
{
    public static void Main()
    {
        string[] menuItems = new string[] { "Задача 34", "Задача 36", "Задача 38", "Выход" };

        Console.WriteLine("Меню");
        Console.WriteLine();

        int row = Console.CursorTop;
        int col = Console.CursorLeft;
        int index = 0;
        while (true)
        {
            DrawMenu(menuItems, row, col, index);
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    if (index < menuItems.Length - 1)
                        index++;
                    Console.Clear();
                    break;
                case ConsoleKey.UpArrow:
                    if (index > 0)
                        index--;
                    Console.Clear();
                    break;
                case ConsoleKey.Enter:
                    switch (index)
                    {
                        case 0:
                            z34();
                            break;
                        case 1:
                            z36();
                            break;
                        case 2:
                            z38();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Выбран выход из приложения");
                            return;
                        default:
                            Console.WriteLine($"Выбрана {menuItems[index]}");
                            break;
                    }
                    break;
            }
        }
    }



  static void z38()  
 {
   Console.WriteLine("Задача 38: Задайте массив вещественных чисел. " 
                          +"Найдите разницу между максимальным и минимальным элементов массива.");

        int num1 = getNumber();               
        var arrayNumbers = generateArrayDoubles(num1, -99, 100);
        Console.WriteLine($"[{String.Join(", ", arrayNumbers)}]");
        Console.Write(" -> " + (Math.Abs(arrayNumbers.Max()) - Math.Abs(arrayNumbers.Min())));
 }
static double[] generateArrayDoubles(int num = 5, int from = -999, int to = 1000)
    {
        var arr = new double[num];
        var random = new Random();
            for (var i = 0; i < num; i++)
            {
                arr[i] = random.Next(from, to) + random.NextDouble();
            }
            return arr;
    }

    static void z36()  
    {
      System.Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами."
      + "Найдите сумму элементов, стоящих на нечётных позициях.");
       int num1 = getNumber();
       RandomNotEven(num1);

    }
static void RandomNotEven(int number)
    {
        var rand = new Random();
        int[] mass = new int[number];
        int summ = 0;
        for (var i = 0; i < number; i++)
        {
         mass[i] = rand.Next(-99,100);
         if(i%2!=0)
         { 
          summ = summ + mass[i];
         }
        }
        Console.WriteLine($"[{String.Join(", ", mass)}] -> {summ}");
    }



    static void z34()
    {
        System.Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами."
        + " Напишите программу, которая покажет количество чётных чисел в массиве.");
        int num1 = getNumber();
        RandomArray(num1);


    }

    static int getNumber()
    {
        System.Console.WriteLine($"Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    static void RandomArray(int number)
    {
        var rand = new Random();
        int[] mass = new int[number];
        int even = 0;
        for (var i = 0; i < number; i++)
        {
         mass[i] = rand.Next(100,1000);
         if(mass[i] % 2 == 0)
         { 
          even++;
         }
        }
        Console.WriteLine($"[{String.Join(", ", mass)}] -> {even}");
    }

private static void DrawMenu(string[] items, int row, int col, int index)
    {
        Console.SetCursorPosition(col, row);
        for (int i = 0; i < items.Length; i++)
        {
            if (i == index)
            {
                Console.BackgroundColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
            }

            Console.WriteLine(items[i]);
            Console.ResetColor();
        }

        Console.WriteLine();
    }

}
