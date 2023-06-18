// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int value = Promt("Введите пятизначное число");
CheckPalindromDigit(value);

int Promt(string message) 
{
    Console.WriteLine(message);
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return number;
}

void CheckPalindromDigit (int x)
{
if (x < 10000 || x > 99999)
{
    Console.WriteLine("Введено не верное число");
}
else if (x/10000 == (x)%10 && (x/1000)%10 == (x/10)%10) 
{
    Console.WriteLine("Введенное число - палиндром");
}
else 
{
    Console.WriteLine("Число не палиндром");
}
}
