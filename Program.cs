int age = 15;
if (age >= 18)
{
    Console.WriteLine("Доступ разрешён");
    } else {
         Console.WriteLine("Доступ запрещён");
         Console.WriteLine($"Лет до совершеннолетия: {18 - age}");
}