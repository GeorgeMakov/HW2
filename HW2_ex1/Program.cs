Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
//    if (a % 23 == 0);
    Console.WriteLine($"Ваше число {a} кратно 7 и 23");
else
{
    Console.WriteLine($"Ваше число {a} не кратно 7 или 23");
}