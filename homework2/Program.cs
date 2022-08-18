// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int a1 = Coordinate("a", "A");
int b1 = Coordinate("b", "B");
int c1 = Coordinate("c", "C");
int a2 = Coordinate("a", "A1");
int b2 = Coordinate("b", "B1");
int c2 = Coordinate("c", "C1");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double a1, double a2, 
                double b1, double b2, 
                double c1, double c2){
  return Math.Sqrt(Math.Pow((a2-a1), 2) + 
                   Math.Pow((b2-b1), 2) + 
                   Math.Pow((c2-c1), 2));
}

double segmentLength =  Math.Round (Decision(a1, a2, b1, b2, c1, c2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");


