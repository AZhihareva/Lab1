using System;

namespace Labs
{
    class Programm
    {
        static void Main(string[] args)
        {
            ABC Math = new ABC();
            Console.Write("Input a: ");
            Math.A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b: ");
            Math.B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a * a - b = " + Math.C);
            Console.Write("Press any key to exit");
            Console.ReadKey();
            Console.Clear();
        }
    }
    public class ABC
    {
        private int a;
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        private int b;
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int C
        {
            get { return A * A - B; }
        }
    }
}