using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
   public class Numbers : IEnumerable<int> // IEnumerable<int>
    {
        private readonly int[] numbers;

        public Numbers(int[] numbers)
        {
            this.numbers = numbers;
        }
        public int Count => this.numbers.Length;

        public IEnumerator<int> GetEnumerator()
        {
            return new NumbersEnumerator(this.numbers);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator(); // always return this.GetEnumerator()
        }


        private class NumbersEnumerator : IEnumerator<int> // IEnumerator<int>
        {
            private readonly int[] numbers;
            private int currentIndex = -1; // add currentIndex

            public NumbersEnumerator(int[] numbers)
            {
                this.Reset(); // add Reset()
                this.numbers = numbers;
            }

            public int Current => this.numbers[currentIndex];

            object IEnumerator.Current => this.Current; // always return this.Current

            public bool MoveNext()
            {
                this.currentIndex++;
                if (this.currentIndex >= this.numbers.Length)
                {
                    return false;
                }

                return true;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }

            public void Dispose()
            {

            }
        }
    }
}
