// написать прогу, кот на вход принимает число и на выход выдаёт её квадрат
// на вход это команда у нас- Console.ReadLine


Console.Write(" Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Квадрат числа" + number + "равен =" + sqr);
