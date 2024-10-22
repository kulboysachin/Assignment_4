using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_assignment4
{


    //Q1


//public class Storage<T>
//{

//    public T Item { get; set; }


//    public Storage(T item)
//    {
//        Item = item;
//    }
//}

//class Program
//{
//    static void Main()
//    {

//        Storage<int> intStorage = new Storage<int>(10);
//        Console.WriteLine($"Stored integer: {intStorage.Item}");

//        Storage<string> stringStorage = new Storage<string>("Hello, World!");
//        Console.WriteLine($"Stored string: {stringStorage.Item}");

//        Storage<double> doubleStorage = new Storage<double>(99.99);
//        Console.WriteLine($"Stored double: {doubleStorage.Item}");
//    }
//}



//Q2




//    public class Pair<T1, T2>
//    {
//        public T1 First { get; set; }
//        public T2 Second { get; set; }

//        public Pair(T1 first, T2 second)
//        {
//            First = first;
//            Second = second;
//        }

//        public void PrintPair()
//        {
//            Console.WriteLine($"First: {First}, Second: {Second}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Pair<int, string> intStringPair = new Pair<int, string>(1, "One");
//            intStringPair.PrintPair();

//            Pair<string, double> stringDoublePair = new Pair<string, double>("PI", 3.14159);
//            stringDoublePair.PrintPair();
//        }
//    }
//}


//Q3



//    public class Calculator<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
//    {

//        public T Add(T a, T b)
//        {
//            return (dynamic)a + (dynamic)b;
//        }
//        public T Subtract(T a, T b)
//        {
//            return (dynamic)a - (dynamic)b;
//        }
//        public T Multiply(T a, T b)
//        {
//            return (dynamic)a * (dynamic)b;
//        }


//        public T Divide(T a, T b)
//        {
//            if ((dynamic)b == 0)
//                throw new DivideByZeroException("Cannot divide by zero.");
//            return (dynamic)a / (dynamic)b;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {

//            Calculator<int> intCalculator = new Calculator<int>();
//            Console.WriteLine($"Addition: {intCalculator.Add(10, 5)}");
//            Console.WriteLine($"Division: {intCalculator.Divide(10, 2)}");

//            Calculator<double> doubleCalculator = new Calculator<double>();
//            Console.WriteLine($"Multiplication: {doubleCalculator.Multiply(5.5, 2.0)}");
//            Console.WriteLine($"Subtraction: {doubleCalculator.Subtract(10.5, 4.3)}");
//        }
//    }
//}



//Q4



//public class Stack<T>
//{
//    private List<T> items = new List<T>();

//    public void Push(T item)
//    {
//        items.Add(item);
//    }

//    public T Pop()
//    {
//        if (items.Count == 0)
//            throw new InvalidOperationException("Stack is empty.");
//        T item = items[items.Count - 1];
//        items.RemoveAt(items.Count - 1);
//        return item;
//    }

//    public T this[int index]
//    {
//        get
//        {
//            if (index < 0 || index >= items.Count)
//                throw new IndexOutOfRangeException("Invalid index.");
//            return items[index];
//        }
//    }

//    public int Count => items.Count;
//}

//class Program
//{
//    static void Main()
//    {
//        Stack<int> stack = new Stack<int>();
//        stack.Push(10);
//        stack.Push(20);
//        stack.Push(30);

//        Console.WriteLine($"Bottom of the stack: {stack[0]}");
//        Console.WriteLine($"Top of the stack: {stack[stack.Count - 1]}");
//        Console.WriteLine($"Popped: {stack.Pop()}");
//    }
//}



//Q5



//    public class Queue<T>
//    {
//        private List<T> items = new List<T>();
//        public void Enqueue(T item)
//        {
//            items.Add(item);
//        }
//        public T Dequeue()
//        {
//            if (items.Count == 0)
//                throw new InvalidOperationException("Queue is empty.");
//            T item = items[0];
//            items.RemoveAt(0);
//            return item;
//        }
//        public T this[int index]
//        {
//            get
//            {
//                if (index < 0 || index >= items.Count)
//                    throw new IndexOutOfRangeException("Invalid index.");
//                return items[index];
//            }
//        }
//        public int Count => items.Count;
//    }

//    class Program
//    {
//        static void Main()
//        {
//            Queue<string> queue = new Queue<string>();
//            queue.Enqueue("First");
//            queue.Enqueue("Second");
//            queue.Enqueue("Third");
//            Console.WriteLine($"First in the queue: {queue[0]}");
//            Console.WriteLine($"Last in the queue: {queue[queue.Count - 1]}");
//            Console.WriteLine($"Dequeued: {queue.Dequeue()}");
//        }
//    }
//}