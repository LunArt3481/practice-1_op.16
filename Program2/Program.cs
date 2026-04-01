double price = 1000;
double percent = 0.02;
double increase = 0;
int month_counter = 0;
int counter = 0;
int inc_counter = 0;
int task_month = 0;
int task_inc_month = 0;
for (double i = 0; increase <= 30; month_counter++)
{
    increase = (price * percent);
    i += increase;
    price += increase;

    if (price >= 1200 && counter == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        task_month = month_counter;
        counter++;
    }
    if (increase >= 30 && inc_counter == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        task_inc_month = month_counter;
        inc_counter++;
    }
    Console.WriteLine($"Цена {price:F2}| Увеличение {increase:F2}| Месяц {month_counter}");
    Console.ForegroundColor = ConsoleColor.White;
    
    
}
Console.WriteLine($"\nЧерез {task_month} месяц(ев) вклад превысит 1200 руб. \nЗа {task_inc_month} месяц увеличение вклада превысит 30 руб.");