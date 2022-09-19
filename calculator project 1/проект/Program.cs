using System.Runtime.InteropServices;

Console.WriteLine("1. Сложить 2 числа\r\n" +
    "2. Вычесть первое из второго\r\n" +
    "3. Перемножить два числа\r\n" +
    "4. Разделить первое на второе\r\n" +
    "5. Возвести в степень N первое число\r\n" +
    "6. Найти квадратный корень из числа\r\n" +
    "7. Найти 1 процент от числа\r\n" +
    "8. Найти факториал из числа\r\n" +
    "9. Выйти из программы");

bool isListening = true;
do 
{; 
    Console.WriteLine("Введите номер команды:");
    int answer = Convert.ToInt16(Console.ReadLine());
    if (answer == 1) 
    {
        Console.WriteLine("Введите первое число:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычеслений:");
        Console.WriteLine(number + number2);
        continue;
    }
    else if (answer == 2)
    {
        Console.WriteLine("Введите первое число:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычеслений:");
        Console.WriteLine(number - number2);
        continue;
    }
    else if (answer == 3)
    {
        Console.WriteLine("Введите первое число:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычеслений:");
        Console.WriteLine(number * number2);
        continue;
    }
    else if (answer == 4)
    {
        Console.WriteLine("Введите первое число:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычеслений:");
        Console.WriteLine(number / number2);
        continue;
    }
    else if (answer == 5)
    {
        Console.WriteLine("Введите первое число:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень в которую будет возводиться перве число:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычеслений:");
        Console.WriteLine(Math.Pow(number, number2));
        continue;
    }
    else if (answer == 6)
    {
        Console.WriteLine("Введите число из которого будем искать квадратный коронь:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычеслений:");
        Console.WriteLine(Math.Sqrt(number));
        continue;
    }
    else if (answer == 7)
    {
        Console.WriteLine("Введите число из которого будем искать 1 процент:");
        float number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычеслений:");
        Console.WriteLine((number * 1) / 100);
        continue;
    }
    else if (answer == 8)
    {
        Console.WriteLine("Введите число, факториал которого будем искать:");
        int number = Convert.ToInt32(Console.ReadLine());
        int f = 1;
        Console.WriteLine("Результат вычеслений:");
        while (number > 1)
        {
            f *= number;
            number -= 1;
        }
        Console.WriteLine(f);
        continue;
    }
    else if (answer == 9)
    {
        isListening = false;
    }
    else
    {
        Console.WriteLine("Вы ввели неправильную команду, попробуйте ещё раз.");
        continue;
    }
} 
while (isListening == true);
