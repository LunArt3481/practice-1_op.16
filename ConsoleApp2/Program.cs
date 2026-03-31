//using System.Globalization
//CultureInfo.InvariantCulture

void task(int num)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Пункт номер {num}.");
    Console.ForegroundColor = ConsoleColor.White;
}

task(1);

int[] a_list = new int[401];
long sum = 0;
int b = 0;
int a = 0;

//const double g = 9.8; 
//g = Convert.ToDouble(g);

for (int i = 0; i < a_list.Length; i++)
{
    a_list[i] = 200 + i;
    sum += a_list[i];
}
Console.WriteLine($"Сумма чисел в диапозоне от 200 до 600 = {sum}\n\n");
sum = 0;

task(2);

number:
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Ваше число (не меньше -15): ");
try
{
    b = Convert.ToInt32(Console.ReadLine()!);
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
    goto number;
}
if (b <= -15)
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("БОЛЬШЕ -15");
    goto number;
}

int length = 16 + b;
int[] b_list = new int[length];
for (int i = 0; i < b_list.Length; ++i)
{
    b_list[i] = i - 15;
    sum += b_list[i];
}
Console.WriteLine($"{sum}\n\n");
sum = 0;

task(3);

number_b:
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Первое число диапозона: ");
try
{
    b = Convert.ToInt32(Console.ReadLine()!);
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
    goto number_b;
}

number_a:
Console.WriteLine("Второе число диапозона: ");
try
{
    a = Convert.ToInt32(Console.ReadLine()!);
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
    goto number_a;
}
if (b >= a)
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Начало диапозона должно быть больше его конца");
    goto number_a;
}


Console.WriteLine($"Начало диапозона {b}, конец {a}. Всё верно?\n1 - да\t2 - перезаписать");
logic_number_set:
Console.ForegroundColor = ConsoleColor.White; 
int logic_number = 0;

try
{
    logic_number = Convert.ToInt16(Console.ReadLine()!);
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Ошибка: {e.Message}\nПопробуйте снова\n");
    Console.ForegroundColor = ConsoleColor.White;
    goto logic_number_set;
}

switch (logic_number)
{
    case 1:
        {
            goto continue_counting;
        }
    case 2:
        {
            goto number_b;
        }
    default:
        {
            Console.WriteLine("Ввод был обработан, но не было найдено правильное действие");
            break;
        }
}
continue_counting:
int[] c = new int[a - b + 1];
c[0] = b;
sum += b;
for (int i = 1; i < c.Length; i++)
{
    c[i] = b + i;
    sum += c[i];
}
Console.WriteLine($"Сумма чисел в диапозоне от {b} до {a} = {sum}");
