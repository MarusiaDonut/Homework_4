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
        List<string> container = new List<string>();
        int top;


        //Конструктор
        public Stack(params string[] container)
        {
            this.container = container.ToList();
            top = container.Length;
        }


        //Свойства
        public int Size
        {
            get => top;
        }

        public string Top
        {
            get
            {
                if (top == 0)
                {
                    return null;
                }
                else
                {
                    return container[top - 1];
                }
            }
        }


        //Методы
        public string Add(string character)
        {
            top++;
            return container[0] = character;
        }

        public string Pop()
        {
            if (container.Count == 0)
            {
                throw new Exception("Стек пустой!");
            }
            else
            {
                top--;
                return container[top];
            }
        }

       
    }
}
