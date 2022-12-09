//Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Vvedite 4islo");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1%7 == 0)
if(num1%23 == 0)
{
    Console.WriteLine("Ja");
}
else
{
    Console.WriteLine("Nein");
}