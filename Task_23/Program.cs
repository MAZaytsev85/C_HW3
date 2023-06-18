// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int value = Promt("Введите число N");
ResultDigit(value);

int Promt(string message) 
{
    Console.WriteLine(message);
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}

void ResultDigit (int N) 
{
int count = 0;
int i = 1;
while (count < N) 
{
double result = Math.Pow(i, 3);
Console.WriteLine(result);   
i++;
count++;
}
}
