// Дополнительные задачи14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

namespace Project
{ 
    class Program
    {
        static void Main(string[] args)
        {
           void Zadacha()
           {
                Console.WriteLine("Введите первое число:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % (7*23) == 0)
                {
                    Console.WriteLine("Число" + number + " кратно числам 7 и 23");
                }
                else
                {
                    Console.WriteLine("Число" + number + " не кратно числам 7 и 23 одновременно");
                }
            }
           Zadacha();
        }
    }    
}  