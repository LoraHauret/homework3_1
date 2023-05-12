Console.Write("\n\tВведите число:");
int number = Convert.ToInt32(Console.ReadLine());
bool isPolindrome = IsPolindrome(number);
PrintResult(isPolindrome);

void PrintResult(bool res) => Console.WriteLine("\n\tЧисло " + (res ? "является " : "не является ") + "полиндромом");

bool IsPolindrome(int aNumber)
{
    int number = aNumber;
    if (number == 0)
        return false;
    int countNumberRow = 0, tempNumber = 0;
    while (number > 0)
    {

        tempNumber = tempNumber * 10 + number % 10; //(int)Math.Pow(10, countNumberRow); 
        ++countNumberRow;
        number /= 10;
    }
    return tempNumber == aNumber;
}


