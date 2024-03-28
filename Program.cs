// Задача 72:** Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит
// массив десятичных представлений чисел массива data с учётом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
// Тимур: входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1

using static System.Console;

WriteLine(String.Join(", ", GetResult(new int[]{0, 1, 1, 1, 1, 0, 0, 0, 1}, new int[]{2, 3, 3, 1})));

int[] GetResult(int[] data, int[] inf)
{
   int[] result = new int[inf.Length];
   string subData = String.Join("",data);
   for (int i = 0; i < inf.Length; i++)
   {
      string str = subData.Substring(0, inf[i]);
      result[i] = Convert.ToInt32(str, 2);
      subData = subData.Remove(0, inf[i]);
   }
   return result;
}