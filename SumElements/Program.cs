// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Random random = new Random();
int[] array = FillArray(PutNumber("Введите нужное количество чисел в массиве : "));
ReadArray(array);
System.Console.WriteLine($"Сумма элементов на нечетных позициях : {SumElements(array)}");

int SumElements(int[] array)
{
  int sumElements = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 != 0)
      sumElements += array[i];
  }
  return sumElements;
}

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
    array[i] = random.Next(-10, 11);
  }
  return array;
}

void ReadArray(int[] array)
{
  System.Console.WriteLine(String.Join(" ", array));
}
