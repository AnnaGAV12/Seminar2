Console.Write("Введите координаты Х: ");
int coordX = int.Parse(Console.ReadLine());
Console.Write("Введите координаты Y: ");
int coordY = int.Parse(Console.ReadLine());
if (coordX < 0 && coordY < 0)
{
    Console.WriteLine("Координаты вашей точки в 1 четверти плоскости ");
}
else if (coordX < 0 && coordY > 0)
{
    Console.WriteLine("Координаты вашей точки во 2 четверти плоскости ");
}
else if (coordX > 0 && coordY > 0)
{
    Console.WriteLine("Координаты вашей точки в 3 четверти плоскости ");
}
else if (coordX > 0 && coordY < 0)
{
    Console.WriteLine("Координаты вашей точки в 4 четверти плоскости ");
}
else
    Console.WriteLine("Ваша точка вне плоскостей");

