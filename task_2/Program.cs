// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write(" Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number == 1) {
    Console.WriteLine("понедельник");
}
if (number == 2) {
    Console.WriteLine("вторник");
}