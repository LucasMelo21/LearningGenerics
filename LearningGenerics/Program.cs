using System;
using LearningGenerics.Services;

namespace LearningGenerics {
    class Program {
        public static void Main(string[] args) {
            PrintService print = new PrintService();
            Console.Write("How many values? ");
            int values = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the values: ");
            for (int i = 0; i < values; i++) {
                int value = int.Parse(Console.ReadLine());
                print.AddValue(value);
            }
            print.Print();
            Console.WriteLine("First: " + print.First());
        }
    }
}