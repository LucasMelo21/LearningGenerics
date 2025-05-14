using System;
using LearningGenerics.Entities;
using LearningGenerics.Services;

namespace LearningGenerics {
    class Program {
        public static void Main(string[] args) {
            List<Product> product = new List<Product>();

            Console.Write("How many values? ");
            int values = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the values: ");
            for (int i = 0; i < values; i++) {
                string x = (Console.ReadLine());
                product.Add(new Product(x));
            }
            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(product);

            Console.Write("Max: ");
            Console.WriteLine(max);
        }
    }
}