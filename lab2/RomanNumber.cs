using System.Text;

namespace lab2
{
    public class RomanNumber : ICloneable, IComparable
    {
        private const int nn = 13;
        private static int[] numbers_int = new int[nn] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        private static string[] numbers_string = new string[nn] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        private ushort num = 0;

        //Конструктор получает число n, которое должен представлять объект класса
        public RomanNumber(ushort n)
        {
            num = n;
            if (n <= 0) throw new RomanNumberException("Введено некорректное значение! Число должно быть больше нуля.");
        }
        //Сложение римских чисел
        public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1.num <= 0 || n2.num <= 0) throw new RomanNumberException("Введено некорректное значение при сложении!");
            else
            {
                int res = n1.num + n2.num;
                RomanNumber result = new RomanNumber((ushort)res);
                return result;
            }
        }
        //Вычитание римских чисел
        public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1.num <= 0 || n2.num <= 0) throw new RomanNumberException("Введено некорректное значение при вычитании!");
            else
            {
                int res = n1.num - n2.num;
                if (res <= 0)
                {
                    throw new RomanNumberException("Ошибка при вычитании! Результат вычитания был меньше или равен нулю.");
                }
                RomanNumber result = new RomanNumber((ushort)res);         
                return result;
            }
        }
        //Умножение римских чисел
        public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1.num <= 0 || n2.num <= 0) throw new RomanNumberException("Введено некорректное значение при умножении!");
            else
            {
                int res = n1.num * n2.num;
                RomanNumber result = new RomanNumber((ushort)res);
                return result;
            }
        }
        //Целочисленное деление римских чисел
        public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1.num <= 0 || n2.num <= 0) throw new RomanNumberException("Введено некорректное значение при целочисленном делении!");
            else
            {
                int res = n1.num % n2.num;
                if (res <= 0)
                {
                    throw new RomanNumberException("Ошибка при целочисленном делении! Остаток от деления равен нулю.");
                }
                RomanNumber result = new RomanNumber((ushort)res);
                return result;
            }
        }
        //Возвращает строковое представление римского числа
        public override string ToString()
        {
            int t = num;
            StringBuilder result = new StringBuilder();
            for (int i = nn - 1; i >= 0; i--)
            {
                while (t >= numbers_int[i])
                {
                    t -= numbers_int[i];
                    result.Append(numbers_string[i]);
                }
            }
            return result.ToString();
        }


        public object Clone()
        {
            return new RomanNumber(num);
        }

        public int CompareTo(object obj)
        {
            if (obj is RomanNumber Roman)
                return num.CompareTo(Roman.num);
            else
                throw new RomanNumberException("Не удалось провести сравнение");
        }

    }
}
