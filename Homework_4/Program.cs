using System.Collections;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            var s = new Stack("a", "b", "c");
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            string deleted = s.Pop();
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
            s.Add("d");
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            s.Pop();
            s.Pop();
            s.Pop();
            Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
            s.Add("m");
            Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
            var s1 = new Stack("a", "b", "c");
            s1.Merge(new Stack("1", "2", "3"));
        }
    }
}
