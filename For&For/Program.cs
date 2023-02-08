
Console.Clear();
for(int i = 2;i <= 10 ;i++)  // внешний цикл
{
  for(int j = 0; j <= 10; j++) // внутренний цикл
  {
    Console.WriteLine($"{i} * {j} = {i*j}");  // {i} * {j} = {i*j}  --  интерполяция строк
  }
  Console.WriteLine();
}
