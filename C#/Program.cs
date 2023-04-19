// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = new string[] {"12-2-", "---", "Sert", "Sec", "S"};
string[] array2 = new string[array1.Length];

void Print(string[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

void Mas(string[] array1, string[] array2)
{
  int x = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= 3)
    {
      array2[x] = array1[i];
      x++;
    }
  }
}

Mas(array1, array2);
Print(array2);
