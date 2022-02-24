namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RomanNumber n1 = new RomanNumber(11);
                RomanNumber n2 = new RomanNumber(5);
                RomanNumber n3 = new RomanNumber(22);
                RomanNumber[] mas = { n1, n2, n3 };
                Console.WriteLine($"Числа для арифметических операций: {n1.Clone().ToString()} , {n2.Clone().ToString()} .\n");
                Console.WriteLine($"Сложение: {RomanNumber.Add(n1, n2).ToString()}\n");
                Console.WriteLine($"Вычитание: {RomanNumber.Sub(n1, n2).ToString()}\n");
                Console.WriteLine($"Умножение: {RomanNumber.Mul(n1, n2).ToString()}\n");
                Console.WriteLine($"Целочисленное деление: {RomanNumber.Div(n1, n2).ToString()}\n");
                Console.WriteLine($"\n--- Проверка сортировки чисел: {n1.ToString()}, {n2.ToString()}, {n3.ToString()}\n");
                Array.Sort(mas);
                Console.WriteLine($"Результат:\n");
                foreach (var arr in mas)
                {
                    Console.WriteLine(arr.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"В ходе выполения программы возникла ошибка:\n\n {ex.Message}\n\n");
            }
        }
    }



}