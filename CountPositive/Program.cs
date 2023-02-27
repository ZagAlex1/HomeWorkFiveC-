// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

Random random = new Random();
int[] array = FillArray(PutNumber("Введите нужное количество чисел в массиве : "));
ReadArray(array);
System.Console.WriteLine($"Положительных чисел в массиве : {CountPositive(array)}");

int PutNumber(string greeting)
{
  System.Console.Write(greeting);
  int number = Convert.ToInt32(Console.ReadLine());
  return number;
}

int[] FillArray(int number)
{
  int[] array = new int[number];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(100, 1000);
  }
  return array;
}

void ReadArray(int[] array)
{
  System.Console.WriteLine(String.Join(" ", array));
}

int CountPositive(int[] array)
{
  int countPosNum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
      countPosNum++;
  }
  return countPosNum;
}