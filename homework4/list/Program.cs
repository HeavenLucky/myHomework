using System;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>();            var sum = 0;                       for (int i = 0; i < 10; i++)            {                list.Add(i);            }            int min;            int max = min = list.Head.Data;            list.ForEach(Console.WriteLine);            list.ForEach(d => sum += d);            Console.WriteLine($"和为{sum}");            list.ForEach(d =>            {                if (min > d)                {                    min = d;                }            });            Console.WriteLine($"最小值为{min}");            list.ForEach(d =>            {                if (max < d)                {                    max = d;                }            });            Console.WriteLine($"最大值为{max}");        }

    }



    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {

            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)        {            Node<T> node = head;            while (node != tail && head != null)            {                action(node.Data);                node = node.Next;            }        }





    
    }
}