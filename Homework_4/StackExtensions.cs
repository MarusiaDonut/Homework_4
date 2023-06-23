using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal static class StackExtensions
    {
       
        public static void Merge(this Stack stack1, Stack stack2)
        {
            int num = stack2.Size;
            for (int i = 0; i < num; i++)
            {
                string s = stack2.Top;
                stack2.Pop();
                stack1.Add(s);
            }
        }
    }
}
