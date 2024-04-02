//Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

using static System.Console;

int[,] array = new int[4,4];
RandomArray(array);
PrintArray(array);
WriteLine();
int[] serch = SerchMinNum(array);
PrintArray(DeletLinEndColum(array,serch));

int[,] DeletLinEndColum(int[,] array, int[] serch)
{
   int[,] result = new int[array.GetLength(0)-1,array.GetLength(1)-1];
   int x = 0;
   int z = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if(i != serch[0] && j != serch[1])
         {
            result[x,z] = array[i,j];
            z ++;
         }
      }
      z = 0;
      if(i != serch[0]) x++;
   }
   return result;
}

int[] SerchMinNum(int[,] array)
{
   int curent = array[0,0];
   int[] result = new int[2];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if(array[i,j] < curent)
         {
            curent = array[i,j];
            result[0] = i;
            result[1] = j;
         }
      }
   }
   return result;
}

void RandomArray(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         arr[i,j] = new Random().Next(1,10);
      }
   }
}

void PrintArray(int[,] prinArray)
{
   for (int i = 0; i < prinArray.GetLength(0); i++)
   {
      for (int j = 0; j < prinArray.GetLength(1); j++)
      {
         if (prinArray[i,j] < 10) Write($"{prinArray[i,j]}  ");
         else Write($"{prinArray[i,j]} ");
      }
      WriteLine();
   }
}