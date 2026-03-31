double price = 1000;
double percent = 0.02;
double increase = 0;
int month_counter = 0;
int counter = 0;
for (double i = 0; increase <= 30; month_counter++)
{
    increase = (price * percent);
    i += increase;
    price += increase;
    Console.WriteLine($"Цена {price + i:F2}| Увеличение {increase:F2}| Месяц {month_counter}");
    if (price >= 1200 && counter == 0)
    {
        int task_month = month_counter;
        counter++;
    }
}
Console.WriteLine(task_month);