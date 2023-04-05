using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_lesson_1
{
    public class myTest
    {
        public int a;
        public myTest() 
        { 
            Console.WriteLine("Создан объект"); 
        }

        static public int myDouble(int _arg)
        {
            return _arg * 2;
                
        }
    }
    internal class Program
    {
        static void myConvert(string _promt, out int? a)    // out - внешняя переменная
        {
            a = null;
            Console.WriteLine(_promt);
            try
            {
              a = int.Parse(Console.ReadLine());    // метод Parse преобразует строку в число
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            
        }


            static void Main(string[] args)
        {           
            var a = 4;  // bad practic
            int? a1 = null;     // расширенный int, который может содержать null, помогает решить проблему с некорректным вводом от пользователя
            string b = "6a";

            while (a1 == null) {
              myConvert("Введите число:", out a1);
            }
            var aaa = new myTest();
            
            //Console.WriteLine(aaa.myDouble(a));
            myTest.myDouble(3);

            //myConvert("Введите число:", out a1);
            Console.WriteLine(a1);
            Console.WriteLine("============");
            int[] arr = new int[3] { 1, 2, 0 };
            foreach (var i in arr)
            {
                Console.WriteLine(i);                
            }

            Console.WriteLine("============");

            var _list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                _list.Add(arr[i]);
                Console.WriteLine(_list[i]);
            }
            _list.Add(-7);

            Console.WriteLine("============");

            int counter = 0;
            foreach (var item in _list)
            {
                Console.Write("Элемент {0} равен {1}\n",counter, item); // {0} - порядковый номер, item - что это такое
                Console.Write($"Элемент {counter} равен {item}\n");     // идентичная запись; Вместо $ можно написать @ для игнорирования ескейп-последовательностей
                counter++;
            }             
                     
            Console.ReadKey();  // пауза

        }
    }
}
