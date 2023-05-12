Random rand = new Random();

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr, "Исходный массив:");

int[] filterArr = new int[] { -4, -1, 2, 7, 9 };
PrintArray(filterArr, "Массив для фильтрации:");

int[]? resultArray = FilterArray(arr, filterArr);
PrintArray(resultArray, "Отфильтрованный массив:");

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10, 10);
    }
}


void PrintArray(int[] arr, string message)
{
    if (arr != null)
    {
        Console.WriteLine("\n\t{0}\n", message);

        foreach (int i in arr)
        {
            Console.Write("\t{0}", i);
        }
        Console.WriteLine();
    }
}

int[]? FilterArray(int[] arr, int[] filter)
{
    int countLength = 0;
    foreach (int fEl in filter)
    {
        foreach (int aEl in arr)
        {
            if (aEl == fEl)
                ++countLength;
        }
    }
    if (countLength > 0)
    {
        countLength = arr.Length - countLength;
        int[] retArr = new int[countLength];

        foreach (int aEl in arr)
        {
            bool isIn = false;
            foreach (int fEl in filter)
            {
                if (aEl == fEl)
                {
                    isIn = true;
                    break;
                }
            }
            if (!isIn) { retArr[--countLength] = aEl; }
        }
        return retArr;
    }
    return null;
}

