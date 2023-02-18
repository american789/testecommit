using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Point P;
            P.X = 10;
            P.Y = 15;
            Console.WriteLine(P);
            P = new Point();
            Console.WriteLine(P);
        }
    }
}
