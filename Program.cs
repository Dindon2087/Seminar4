
// Напишите цикл,который принимает на вход два числа(A и B) и
//  возводит число A в натуральную степень B.
/*System.Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
Console.Write($"Double is equal {GetDouble(A)}");

    int GetDouble(int A) 
{
    int Double = 1;

    for(int i = 1; i<= B; i++)
{
    Double = Double* A;
}
return Double;
}*/
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
System.Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.Write($"The Sum of numbers is {GetSum(A)}");
 int GetSum (int A)

 {
 
  for(int i = 0; i <A; i++)
  {
    A = A - A%10;
  A = A/10;
  }
 return GetSum(A); 
 }
 // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.(числа любые)
 //int [] Array = GetArray(8);
//Console.Write($"[String.Join(",",Array)}]");
 //int[] GetArray(int size)
 //{
  //int[] Array = new int[size];
  //for(int i = 0; i <size; i++)
 //{
 // Array[i] = new Random().Next();
//}
 //return Array;
 //}






