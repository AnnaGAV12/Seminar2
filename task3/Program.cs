// Решение первое
// Console.WriteLine("Задание. Программа проверяет пятизначное число на палиндромом.");
// Console.Write("ВВедите число: ");
// string Num = (Console.ReadLine() ?? "0");
// if (Num.Length == 5){
//     if (Num[0] == Num[4] && Num[1] == Num[3]) Console.WriteLine($"Число {Num} является полиндромом");
//     else Console.WriteLine($"Число {Num} НЕ является полиндромом");
// }
// else Console.WriteLine("Вы ввели не пятизначное число");


// Решение второе
// Программа проверяет пятизначное число на палиндромом.
//Console.WriteLine("Введите пятизначное число");
//int count = int.Parse(Console.ReadLine()); 
//int count2 = count;
//int index = 0;
//while ( count > 0)
//{
//    int digit = count % 10; // 
//    index = index *10 + digit;
//    count = count / 10;  
//}
//if ( index == count2)
//{
//    Console.WriteLine("Это палиндром");    
//}
//else
//{
    Console.WriteLine("Это не палиндром");
//}


//Решение третье
Console.WriteLine("Задание. Программа проверяет пятизначное число на палиндромом.");
Console.Write("ВВедите число: ");
int Num = int.Parse(Console.ReadLine() ?? "0");
int Digit1 = Num/10000;
int Digit2 = Num/1000%10;
int Digit4 = Num/10%10;
int Digit5 = Num%10;
if (Num > 9999 && Num < 100000){
    if ((Digit1 == Digit5) && (Digit2 == Digit4)) Console.WriteLine($"Число {Num} является полиндромом");
    else Console.WriteLine($"Число {Num} НЕ является полиндромом");
}
else Console.WriteLine("Вы ввели не пятизначное число");

