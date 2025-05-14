using System;

namespace LearningGenerics.Services {
    internal class PrintService<T> where T : IComparable<T> {

        private T[] _values = new T[10];
        private int _count = 0;
        public void AddValue(T value) {
            if (_count == 10) {
                throw new InvalidOperationException("An error ocurred! Print Service is full!");
            }
            _values[_count] = value;
            _count++;
        }
        public void Order() {
            Array.Sort(_values, 0, _count, Comparer<T>.Create((x, y) => y.CompareTo(x)));
        }
        
        public T First() {
            if (_count == 0) {
                throw new InvalidOperationException("An error ocurred! Print Service is empty!");
            }
            return _values[0];
        }
        public void Print() {
            Console.Write("[");
            for(int i = 0; i < _count - 1; i++) {
                Console.Write($"{_values[i]}, ");
            }
            if (_count > 0) {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
