Console.Clear();
Console.WriteLine("Программа показывающая расстояние между точками");
int x = Coordinate("x", "A");
int y = Coordinate("y", "A");
int z = Coordinate("z", "A");
int x1 = Coordinate("x", "B");
int y1 = Coordinate("y", "B");
int z1 = Coordinate("z", "B");
int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x, double x1, 
                double y, double y1, 
                double z, double z1){
  return Math.Sqrt(Math.Pow((x1-x), 2) + 
                   Math.Pow((y1-y), 2) + 
                   Math.Pow((z1-z), 2));
}

double segmentLength =  Math.Round (Decision(x, x1, y, y1, z, z1), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");