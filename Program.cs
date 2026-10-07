int age = 17;
if (age < 13)
{
    Console.WriteLine("Ребёнок");
} else if (age < 18)
{
    Console.WriteLine("Подросток");
} else if (age >= 60)
{
    Console.WriteLine("Пенсионер");
} else
{
    Console.WriteLine("Взрослый");
} 

int age = 16;
double height = 1.4;
if (age >= 14 && height >= 1.5)
{
    Console.WriteLine("Можно кататься");
} else
{
    Console.WriteLine("Пока нельзя");
}
if (age >= 14 && height <= 1.5)
{
    Console.WriteLine("Можно кататься с сопровождение взрослого");
}