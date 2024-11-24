using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    public class QArray
    {
        int[] ArrayQu;
        int rear;
        int front;
        int size;

        public QArray(int size)
        {
            this.size = size;
            ArrayQu = new int[size];
            front = -1;
            rear = -1;

        }

        public bool isFull()
        {
            return (rear == size);
        }
        public bool isEmpty(object newitem)
        {
            return (rear == front);
        }
        public void EnQueue(int element)
        {
            ArrayQu[rear++] = element;
        }
        public int Dequeue()
        {
            return ArrayQu[front++];
        }
        public int Front()
        {
            return ArrayQu[front];
        }
        public int Qarraysize()
        {
            return rear - front;
        }
        public void Display() 
        {
            Console.WriteLine("The elements of Queue is :");
            for(int i=front; i<rear; i++)
                Console.WriteLine(ArrayQu[i]);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            QArray q1 = new QArray(10);
            QArray q2 = new QArray(10);
            for (int i = 0; i < 8; i++) 
            {
                if (q1.isFull())
                {
                    Console.WriteLine("Queue is Full !");
                    break;
                }
                 else 
                {
                  Console.WriteLine("input your element");
                  int x = int.Parse(Console.ReadLine());
                }
            }
            Console.ReadKey();


        }
    }
}
