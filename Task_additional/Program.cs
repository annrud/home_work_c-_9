//Заданы 2 массива: info и data. В массиве data хранятся
//двоичные представления нескольких чисел (без разделителя).
//В массиве info хранится информация о количестве бит,
//которые занимают числа из массива data. Напишите программу,
//которая составит массив десятичных представлений чисел
//массива data с учётом информации из массива info.
//входные данные:
//data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
//info = {2, 3, 3, 1 }
//выходные данные:
//1, 7, 0, 1


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[][] arrayOfArray = DivideArray(data, info);
int[] result = GetResult(arrayOfArray);
Console.WriteLine(string.Join(", ", result));

int ConvertBinToDec(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length ; i++)
    {
        sum += (int)Math.Pow(2, i) * numbers[i];
    }

    return sum;
}

int[][] DivideArray(int[] array, int[] separator)
{
    int[][] newArray = new int[separator.Length][];
    int cnt = 0;
    int next = 0;
    for (int i = 0; i < separator.Length; i++)
    {
        next = cnt + separator[i];
        newArray[i] = array[cnt..next];
        cnt = next;
    }

    return newArray;
}

int[] GetResult(int[][] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        Array.Reverse(arr[i]);
        result[i] = ConvertBinToDec(arr[i]);
    }

    return result;
}
