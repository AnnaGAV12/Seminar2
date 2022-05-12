//Дано число. Проверить кратно ли оно 7 и 23

//Console.Write("Введите заданное число ");
//int namber1 = int.Parse(Console.ReadLine());
//if (namber1 % 7 == 0) Console.WriteLine($"{namber1} число кратное 7 ");
//if (namber1 % 23 == 0) Console.Write($"{namber1} число кратное 23 ");

// if ( namber1 % 7 == 0 | namber1 % 23 == 0 ) Console.WriteLine($"{namber1} число кратное 7 и 23 ");
//else 
//Console.WriteLine ($" {namber1} не кратно 7 и 23");

Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
if  (num1 % 7 ==0 && num1 % 23 ==0 ) 
{
    Console.WriteLine ("Число кратно 7  и 23");
}
else
{
    Console.WriteLine ("Число не кратно 7  и 23");
}

