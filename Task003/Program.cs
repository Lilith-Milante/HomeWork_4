// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Оформите заполнение массива и вывод в виде функции

/*void PrintArray(int []r)
{
    for (int i = 0; i < r.Length; i++)
    {
        Console.Write($"{r[i]   }");
    }

}
int RandomArray(int Length)
{
    int[] Array;
    Array = new int[Length];
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next (0,8);
    }
return Array;
}
int RanArray = RandomArray;
PrintArray(RanArray);*/


void PrintArray(int []rdm)   // - функция ввода-вывода массива
{
    for (int i = 0; i < rdm.Length; i++)
    {
        Console.Write($"{rdm[i]   }");
    }
}

int []Random = new int[8]; // - создание массива 

for (int i = 0; i > 8; i++)
{
    Random[i] = new Random().Next ();
}


int []RandomArray = Random (8); // - действие функции по выводу массива - в скобках нужно что-то дописать
PrintArray(RandomArray);
Console.WriteLine($"Массив: {RandomArray}");