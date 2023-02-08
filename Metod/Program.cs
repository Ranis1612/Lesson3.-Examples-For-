//Вид 1
void Method1()
{
  Console.WriteLine("Автор Шамсутдинов Р.Р.");
}
//Method1();  если убрать "//" метод включится




// Вид2
void Method2(string msg)  // msg (messeg) именованный аргумент
{
  Console.WriteLine(msg);
}
//Method2(msg:"Текст сообщения");

void Method21(string msg, int count)  // 
{
  int i = 0;
  while(i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
//Method21("Текст", 4);// в случае зацикливания программы необходимо нажать ctrl+C
//Текст
//Текст
//Текст
//Текст


Method21(msg:"Текст1",count: 3);  //ЯВНО указывая наименование аргумента, не обязательно писать их по порядку.
//Текст1
//Текст1
//Текст1




// Вид3
int Method3(){
  return DateTime.Now.Year;
}
int year = Method3();
  Console.WriteLine(year);





// Вид 4
string Method4(int count, string text)
{
  int i = 0;
  string result = String.Empty;  // String.Empty - пустая строка, чтобы было понятно всем лучше писать так , а не "  "
  while(i < count){
    result = result + text;
    i++;
  }
  return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);



