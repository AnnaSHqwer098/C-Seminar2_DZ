
// НА вход трехзначное число и на выход показать вторую цифру этого числа.

int number = new Random().Next(10000);
Console.WriteLine(number);

//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine()!);

if ((number / 100 > 0) && (number / 100 <= 9)) {
    Console.WriteLine($"{number} является трехзначным числом");
    int num1 = number / 10;
    int num2 = num1 % 10;
    Console.WriteLine($"Вторая цифра числа {number} - {num2}"); 
}
else {
    Console.WriteLine($"{number} не является трехзначным числом");
}


// На вход число, на выход показать третью цифру заданного числа, а если ее нет, то сообщение, что ее нет.

int number = new Random().Next(100000);
Console.WriteLine(number);

//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine()!);

if (number / 100 > 0) {
    if (number / 100 <= 9) {
        int num1 = number % 10;
        Console.WriteLine($"Третья цифра числа {number} - {num1}");
    }
    else if (number / 1000 <= 9) {
        int num1 = number % 100 / 10;
        Console.WriteLine($"Третья цифра числа {number} - {num1}"); 
    }
    else if (number / 10000 <= 9) {
        int num1 = number % 1000 / 100;
        Console.WriteLine($"Третья цифра числа {number} - {num1}");
    } 
}
else {
    Console.WriteLine($"В числе {number} нет третьей цифры");
}


//На вход цифру, обозначающую день недели, и проверяет является ли этот день выходным.

Console.WriteLine("Введите число, обозначающее день недели: ");
int number = int.Parse(Console.ReadLine()!);

if ((number >= 1) && (number <= 7)) {
    if ((number == 6) || (number == 7)) {
    Console.WriteLine($"{number} день недели является выходным днем");
    }
    else {
        Console.WriteLine($"{number} день недели не является выходным днем");       
    }
}
else {
    Console.WriteLine($"{number} дня недели не существует");
}
