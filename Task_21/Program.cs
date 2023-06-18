// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int valueAx = Promt("Введите координаты X первой точки");
int valueAy = Promt("Введите координаты Y первой точки");
int valueAz = Promt("Введите координаты Z первой точки");
int valueBx = Promt("Введите координаты X второй точки");
int valueBy = Promt("Введите координаты Y второй точки");
int valueBz = Promt("Введите координаты Z второй точки");

Distance (valueBx, valueBy, valueBz, valueAy, valueAz, valueAx);

int Promt(string message) 
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
  
}

void Distance (int Bx, int By, int Bz, int Ay, int Az, int Ax)
{
double Distance = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
Console.WriteLine(Distance);
}
