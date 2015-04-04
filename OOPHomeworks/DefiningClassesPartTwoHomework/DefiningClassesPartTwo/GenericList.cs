namespace DefiningClassesPartTwo
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable, new()
    {
        private T[] elements;
        private int index;
        private int count = 0;
        private int capacity;

        public GenericList()
        {
            this.elements = new T[8];
            this.index = 0;
            this.capacity = this.elements.Length;
        }

        public int Count
        {
            get { return this.count; }
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        public void Add(T element)
        {
            if (this.count == this.capacity)
            {
                this.DoubleSize();
            }

            this.elements[this.index] = element;
            this.index++;
            this.count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.elements[index];
            }

            set
            {
                if (index < 0 || index >= elements.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.elements[index] = value;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == count - 1)
            {
                this.elements[index] = default(T);
                this.count--;
            }

            else
            {
                for (int i = index; i < this.count; i++)
                {
                    this.elements[i] = this.elements[i + 1];
                }
                this.count--;
            }
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (this.count == this.capacity)
            {
                this.DoubleSize();
            }

            if (index == count)
            {
                this.elements[index] = element;
                this.count++;
                this.index++;
            }

            else
            {
                for (int i = this.count; i > index; i--)
                {
                    this.elements[i] = this.elements[i - 1];
                }
                this.elements[index] = element;
                this.count++;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < this.count; i++)
            {
                this.elements[i] = default(T);
                this.count = 0;
            }
        }

        public int IndexOf(T element)
        {
            return Array.IndexOf(this.elements, element);
        }



        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.AppendLine(elements[i].ToString());
            }
            return result.ToString();
        }

        private void DoubleSize()
        {
            var doubleArr = new T[this.elements.Length * 2];

            for (int i = 0; i < this.elements.Length; i++)
            {
                doubleArr[i] = elements[i];
            }
            this.elements = doubleArr;
            this.capacity *= 2;
        }

        public T Min()
        {
            T min = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }
    }
}
