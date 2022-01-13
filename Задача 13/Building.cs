using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13
{
    /*Задан класс Building, который описывает здание. Класс содержит следующие элементы:
          1 - адрес здания; 2 - длина здания 3 - ширина здания; 4 - высота здания.

      В классе Building нужно реализовать следующие методы:
          1 - конструктор с 4 параметрами; 
          2- свойства get/set для доступа к полям класса; 
          3 - метод Print(), который выводит информацию о здании.

      Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. 
      В классе MultiBuilding реализовать следующие элементы:
          1 - конструктор с 5 параметрами – реализует вызов конструктора базового класса;
          2 - свойство get/set доступа к внутреннему полю класса;
          3 -метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
        Класс MultiBuilding сделать таким, что не может быть унаследован.*/
   
    class Building
    {

        string address; //адрес здания
        float length; // длина здания
        float height; //высота здания
        float width; //ширина здания
        public string ADDRESS { get { return address; } set { address = value; } }
        public float LENGTH { get { return length; } set { length = value; } }
        public float HEIGTH { get { return height; } set { height = value; } }
        public float WIDTH { get { return width; } set { width = value; } }

        public Building(string address, float length, float width , float height)
        {
            ADDRESS = address;
            LENGTH = length;
            HEIGTH = height;
            WIDTH = width;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Здание по адресу {address} имеет:\r\n\r\n\t\t Длину  {length} м.\r\n\t\t Ширину {width} м.\r\n\t\t Высоту {height} м.");
        }
    }

    sealed class MultiBuilding:Building
    {
        int floors; 
        public int FLOORS { get { return floors; } set { floors = value; } }    
        public MultiBuilding(string address, float length, float width, float height, int floors)
            :base(address, length, width, height)
        {
            FLOORS = floors;
        }

        //3 -метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
        //Подскажите верно ли сделал это задание? Код рабочий, но правильна ли логика у меня? Да и Print подчеркивается.
        public void Print() 
        {
            Console.WriteLine($"\t\t Kоличество этажей {floors}.");
        }
    }
    
}
