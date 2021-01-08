using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject2
{
    class Stack
    {
        double[] mystack;
        int top;
        int max_size;
        int count;
        public Stack()
        {
            mystack = new double[100];
            top = -1;
            max_size = mystack.Length;
            count = 0;

        }
        public void Push(double item)
        {
            if (top == max_size - 1)
            {
                Console.WriteLine("Your Stack is Empty");
                return;
            }

            else
            {
                mystack[++top] = item;
                count++;
            }
        }
        public void Pop()

        {
            if (top == -1)
            {
                Console.WriteLine("Your Stack is Empty");

            }
            else
            {
                count--;

                double value = mystack[top--];
            }
        }
        public void Delete(double item)
        {
            if (top == -1)
            {
                Console.WriteLine("Your Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i < top; i++)
                {
                    if (mystack[i] == item)
                    {

                        mystack[i] = 0.1;
                        count--;

                    }
                }
            }

        }
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Your Stack is Empty");
                return;
            }
            else
            {
                double x = mystack[0];
                Console.WriteLine(x);
            }

        }
    }
}
