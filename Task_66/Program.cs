Console.Clear();
Console.WriteLine("Программа выводит сумму " +
                  "натуральных чисел в промежутке от M до N.");
Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()!);
int result = GetSum(numberM, numberN);
Console.WriteLine(result);


int GetSum(int numb1, int numb2, int sum=0)
{
    if (numb1 == numb2)
    {
        return sum + numb2;
    }
    else
    {
        return GetSum(numb1+1, numb2, sum + numb1);
    }
}
