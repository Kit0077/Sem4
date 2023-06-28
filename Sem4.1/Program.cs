int MegaSum(int Num)
{
   int Num2 = 0;
   int Num3 = 0;
    while (Num > 0)
    {
        Num2 = Num % 10;
        Num3 = Num2 + Num3;
        Num = Num / 10;
        
    }
    return Num3;
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} равна {MegaSum(number)}");