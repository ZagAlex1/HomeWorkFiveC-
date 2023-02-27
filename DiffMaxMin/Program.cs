// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

Random random = new Random();
int[] array = FillArray(PutNumber("Введите нужное количество элементов в массиве : "));
ReadArray(array);

int maxElement = MaxElement(array);
int minElement = MinElement(array);
System.Console.WriteLine($"Max елемент : {maxElement}; Min элемент : {minElement}");
System.Console.WriteLine($"Разница между Max и Min : {maxElement - minElement}");

int MaxElement(int[] array)
{
  int maxElement = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > maxElement)
      maxElement = array[i];
  }
  return maxElement;
}

int MinElement(int[] array)
{
  int minElement = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < minElement)
      minElement = array[i];
  }
  return minElement;
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
    array[i] = random.Next(-100, 101);
  }
  return array;
}

void ReadArray(int[] array)
{
  System.Console.WriteLine(String.Join(" ", array));
}