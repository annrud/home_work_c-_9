Console.Clear();
Console.WriteLine("Программа вычисляет значение " +
                  "функции Аккермана A(m, n)");
Console.Write("Введите число m: ");
double numberM = Math.Abs(double.Parse(Console.ReadLine()!));
Console.Write("Введите число n: ");
double numberN = Math.Abs(double.Parse(Console.ReadLine()!));
double numberAckerman = Ackerman(numberM, numberN);
Console.WriteLine(numberAckerman);


double Ackerman(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return Ackerman(m - 1, 1);
        }
        else
        {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }
}
