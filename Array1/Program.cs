
int [] arr = {1, 2, 3, 5, 9, 8, 4, 6, 7, 1, 1 };
void PrintArray(int [] array)
{
  int count = array.Length;
  for(int i = 0 ;i < count; i++)
  {
    Console.Write($"{array [i]} ");
  }
   Console.WriteLine();
}
void SelectionSort(int[]array)     // пишем метод для сортировки массива
{
  for(int i = 0; i < array.Length -1; i++)
  {
    int minPosition = i;
    for(int j = i + 1 ; j < array.Length; j++)
    {
      if(array[j] < array[minPosition])  minPosition = j;
    }
    int temporary = array[i];           // простой !!
    array[i] = array[minPosition];      //   обмен !!!!
    array[minPosition] = temporary;     //     переменных местами !!!!
  }
}     

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);