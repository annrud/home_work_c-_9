Console.Clear();
Console.WriteLine("Программа выводит все " +
                  "натуральные числа в промежутке от N до 1.");
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
GetSequence(number);


void GetSequence(int numb)
{
    if (numb == 1)
    {
        Console.WriteLine(1);
    }
    else
    {
        Console.Write($"{numb}, ");
        GetSequence(--numb);
    }
}
                 