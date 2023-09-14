using System;

namespace QueueClass
{
    public class Queue 
    {
        static readonly int MAX = 1000;
        int top = -1;
        int [] queue = new int [MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool EnQueue(int data)
        {

            if(top >= MAX)
            {
                Console.WriteLine("Queue Overflow");
                return false;
            }

            top += 1;
            //top = top + 1
            //top++;
            //++top;
            queue[top] = data;
            return true;

        }

        public int DeQueue()
        {
            if(top < 0)
            {
                Console.WriteLine("Queue Underflow");
                return 0;
            }

            int valor = queue[top];
            top -= 1;
            return valor;
        }

        public void peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }

            Console.WriteLine($"O topo da fila é : {queue[top]}");
        }

        public void PrintQueue()
        {
            if(top < 0 )
            {
                Console.WriteLine("Queue Underflow");
                return;
            }

            Console.WriteLine("Itens da Fila");
            
            for(int i = 0; i < top; i++ )
            {
                string texto = $"Queue [{queue[i]}]";
                Console.WriteLine(texto);

            }
        }
    }
}