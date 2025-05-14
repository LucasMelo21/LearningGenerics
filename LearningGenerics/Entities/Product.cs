using System.Globalization;

namespace LearningGenerics.Entities {
    internal class Product : IComparable {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string csvProduct) {
            string[] vect = csvProduct.Split(", ");
            Name = vect[0];
            Price = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            if(!(obj is Product))
            throw new ArgumentException("An error ocurred. Argument is not a product");

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
        public override string ToString() {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        } 
    }
}
