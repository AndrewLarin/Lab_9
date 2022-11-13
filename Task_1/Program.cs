using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Введите целое число. X=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("1 - Сложение.");
                Console.WriteLine("2 - Вычитание");
                Console.WriteLine("3 - Произведение");
                Console.WriteLine("4 - Частное");
                Console.Write("Ваш выбор: ");
                int z = Convert.ToInt32(Console.ReadLine());
                if (z > 4 || z < 1)
                    throw new Exception("Нет операции с указанным номером");
                if (z == 1)
                    Console.Write("Результат: {0}", x + y);
                if (z == 2)
                    Console.Write("Результат: {0}", x - y);
                if (z == 3)
                    Console.Write("Результат: {0}", x * y);
                if (z == 4)
                    Console.Write("Результат: {0}", x / y);

            }
            catch (DivideByZeroException d)
            {
                Console.Write("Ошибка! На ноль делить нельзя.");
            }
            catch (FormatException d)
            {
                Console.Write("Ошибка! Входная строка имела неверный формат.");
            }
            catch (Exception a)
            {
                Console.Write(a.Message);
            }
            Console.ReadKey();

        }
    }
}
