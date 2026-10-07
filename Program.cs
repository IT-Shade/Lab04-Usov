Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Число чётное");
} else
{
    Console.WriteLine("Число нечётное");
}

Console.Write("Введите год ");
int year = int.Parse(Console.ReadLine());
if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine($"Год является високосным.");
} else
{
    Console.WriteLine($"Год не является високосным.");
}

Console.Write("Введите год: ");
int year = int.Parse(Console.ReadLine());
if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
{
    Console.WriteLine("Год високосный, в феврале 29 дней");
} else
{
    Console.WriteLine("Год не високосный, в феврале 28 дней");
}

Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname)) {
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

Console.Write("Введите возраст пассажира: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Выберите тип места:");
Console.WriteLine("Плацкарт");
Console.WriteLine("Купе");
Console.WriteLine("СВ");
int type = int.Parse(Console.ReadLine());