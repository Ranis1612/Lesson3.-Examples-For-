// string Method4(int count, string text) //  этот вариант через while
// {
//   int i = 0;
//   string result = String.Empty;  // String.Empty - пустая строка, чтобы было понятно всем лучше писать так , а не "  "
//   while(i < count){
//     result = result + text;
//     i++;
//   }
//   return result;
// }
// string res = Method4(10, "qwerty");
// Console.WriteLine(res);


string Method4(int count, string text)  // то же самое через for
{
  string result = String.Empty;  // String.Empty - пустая строка, чтобы было понятно всем лучше писать так , а не "  "
  for(int i = 0;i < count;i++)  //  инициализация условия, проверка счётчика, и инкремент
  {
    result = result + text;
  }
  return result;
}
string res = Method4(10, "qwerty");
// Console.WriteLine(res);




