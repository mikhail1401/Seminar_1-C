// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Type a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

Console.WriteLine(square);


// 1. Напишите программу, котора на вход принимает два
// числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b =  -> нет

Console.WriteLine("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1==number2*number2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


// 3. Напишите программу, которая будет выдавать название дня недели
// по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Type a number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber==1)
{
    Console.WriteLine("Monday");
}
else if(dayNumber==2)
{
    Console.WriteLine("Tuesday");
}
else if(dayNumber==3)
{
    Console.WriteLine("Wednesday");
}
else if(dayNumber==4)
{
    Console.WriteLine("Thursday");
}
else if(dayNumber==5)
{
    Console.WriteLine("Friday");
}
else if(dayNumber==6)
{
    Console.WriteLine("Saturday");
}
else if(dayNumber==7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("We only have 7 days, you dumb ass");
}


// 5. Напишите программу, которая на вход принимает одно
// число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Type a number: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int numberNNeg = numberN * -1;

while(numberNNeg<=numberN)
{
    Console.WriteLine(numberNNeg);
    numberNNeg += 1;
}


// 7. Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает последнюю
// цифру этого числа. 456 -> 6     782 -> 2    918 -> 8

Console.WriteLine("Type a number: ");
int number7 = Convert.ToInt32(Console.ReadLine());

int result7 = number6 % 10;
Console.WriteLine(result6);
