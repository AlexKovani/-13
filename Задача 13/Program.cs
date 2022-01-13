using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            try //Подскажите пожалуйста, правильно ли я делаю, что заключаю весь код в trу?
            {
                Console.Write("Введите адрес здания: ");
                string address = Console.ReadLine();
                Console.Write("Введите длину здания: ");
                float length = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите ширину здания: ");
                float width = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите высоту здания: ");
                float height = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите количество этажей: ");
                int floors = Convert.ToInt32(Console.ReadLine());
                Building building1 = new Building(address, length, width, height);
                building1.Print();
                MultiBuilding b1 = new MultiBuilding(address, length, width, height, floors);
                b1.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
