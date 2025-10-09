using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    public class Pair
    {
        private int first;
        private int second;
        // Свойства
        public int First
        {
            get { return first; }
            set
            {
                if (value % 2 == 0)
                {
                    first = value;
                }
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value % 2 == 0)
                {
                    second = value;
                }
            }
        }
        // Конструктор
        public Pair(int a, int b)
        {
            First = a;
            Second = b;
        }
        // Метод для произведения чисел пары
        public int Product()
        {
            return first * second;
        }
        // Перегруженный метод для произведения двух пар
        public static Pair Product(Pair p1, Pair p2)
        {
            return new Pair(p1.First * p2.First, p1.Second * p2.Second);
        }
        // Для вывода
        public string Show()
        {
            return "Пара чисел: " + first + " и " + second;
        }
    }
}
