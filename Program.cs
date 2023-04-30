// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Enter a three-digit number: ");
int threeDigitNum = Convert.ToInt32(Console.ReadLine());
string stringNum = Convert.ToString(threeDigitNum);
Console.WriteLine("the second digit of this number -> "+stringNum[1]);

*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
Console.Write("Enter your number: ");
int Num = Convert.ToInt32(Console.ReadLine());
string NumText = Convert.ToString(Num);
if (NumText.Length > 2){
  Console.WriteLine("third digit -> " + NumText[2]);
}
else {
  Console.WriteLine("-> no third digit");
}
*/
//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Enter a number for the day of the week: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNum) {
  if (dayNum == 6 || dayNum == 7) 
  {
  Console.WriteLine("(this day is a day off) -> Yes");
  }
  else if (dayNum < 1 || dayNum > 7) 
  {
    Console.WriteLine("it's not a day of the week");
  }
  else Console.WriteLine("(this day is not a day off) -> No");
}

CheckingTheDayOfTheWeek(dayNum);
