// Подсчитать сумму цифр в числе


int n = new Random().Next(1, 100000);
int sumDigit = 0;
Console.Write($"Сумма цифр числа {n} равна ");

while (n > 0)
{
    int digit = n % 10;
    sumDigit = sumDigit + digit;
    n = n / 10;
}

Console.WriteLine(sumDigit);
