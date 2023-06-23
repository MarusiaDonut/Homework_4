using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework_4
{
    internal class Stack
    {
        List<string> container;
        int _top;

        public Stack(params string[] container)
        {
            this.container = container.ToList();
            _top = container.Length;
        }

        public int Size => container.Count;

        public string? Top => _top == 0 ? null : container[_top - 1];
       

        public string Add(string character)
        {

            container.Add(character);
            return container[_top++];
        }

        public string Pop()
        {
            if (container.Count == 0)
            {
                throw new Exception("Стек пустой!");
            }
            else
            {
                 _top--;
                string element = container[_top];
                container.RemoveAt(_top);
                return element;
            }
        }
    }
}
