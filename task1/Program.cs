void DrawRectangle(char symb, uint size)
{
    int startX = 5; int startY = 5;

    Console.SetCursorPosition(startX, startY);
    for (int i = 0; i < size; i++)
    {
        Console.Write(symb);
    }
    Console.WriteLine();
    ++startY;

    for (int i = 1; i <= size - 1; i++)
    {
        Console.SetCursorPosition(startX, startY);
        for (int j = 0; j < size; j++)
        {
            if (j == 0 || j == size - 1)
            {
                Console.Write(symb);
            }
            else
                Console.Write(" ");
        }
        Console.WriteLine();
        ++startY;
    }
    Console.SetCursorPosition(startX, startY);
    for (int i = 0; i < size; i++)
    {
        Console.Write(symb);
    }
    Console.WriteLine();
    Console.WriteLine();
}


DrawRectangle('@', 5);
