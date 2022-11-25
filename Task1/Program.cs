using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
//Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.
//Указание: задача решается однократным проходом по символам заданной строки слева направо;
//для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая,
//каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается);
//в конце прохода стек должен быть пуст.


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            if (Check(str))
            Console.WriteLine("Строка корректна.");
            else
            Console.WriteLine("Строка некорректна");

            Console.ReadLine();
        }

        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> dict = new Dictionary<char, char>()
            {
                {'(',')' },
                {'[',']' },
                {'{','}' }
            };

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                    stack.Push(dict[c]);
                if (dict.ContainsValue(c))
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            return false;
        }
    }
}
