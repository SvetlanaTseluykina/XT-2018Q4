using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DynamicArrayHardcoreMode
{
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable
    {
        protected T[] array;
        protected int count = 0;

        public DynamicArray()
        {
            this.array = new T[8];
        }

        public DynamicArray(int length)
        {
            this.array = new T[length];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Error! Argument is null!");
            }

            int countCollection = 0;
            foreach (var item in collection)
            {
                countCollection++;
            }

            this.array = new T[countCollection];
        }

        public int Capacity
        {
            get
            {
                return this.array.Length;
            }
        }

        public int Length
               => this.count;

        public virtual T this[int index]
        {
            get
            {
                if (index >= this.array.Length)
                {
                    throw new ArgumentOutOfRangeException("Error! Argument is out of range!");
                }

                return this.array[index];
            }

            set
            {
                this.array[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.array.Length == this.count)
            {
                Array.Resize(ref this.array, this.array.Length * 2);
                this.array[this.count++] = item;
            }
            else
            {
                this.array[this.count++] = item;
            }
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Error! Argument is null!");
            }

            int countNum = 0;
            if (this.array.Length == this.count)
            {
                Array.Resize(ref this.array, this.array.Length * 2);
                foreach (var item in collection)
                {
                    this.array.SetValue(item, countNum);
                    countNum++;
                }
            }
            else
            {
                foreach (var item in collection)
                {
                    this.array.SetValue(item, countNum);
                    countNum++;
                }
            }

            this.count = countNum;
        }

        public bool Remove(T item)
        {
            bool fl = false;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(item) && i < this.array.Length - 1)
                {
                    for (int j = i; j < this.array.Length - 1; j++)
                    {
                        this.array[j] = this.array[j + 1];
                    }

                    Array.Resize(ref this.array, this.array.Length - 1);
                    Array.Resize(ref this.array, this.array.Length + 1);

                    fl = true;
                    break;
                }
            }

            if (fl)
            {
                this.count--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= this.array.Length)
            {
                throw new ArgumentOutOfRangeException("Error! Argument is out of range!");
            }

            for (int i = index; i < this.array.Length - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }

            this.count--;
            Array.Resize(ref this.array, this.array.Length - 1);
            Array.Resize(ref this.array, this.array.Length + 1);
        }

        public bool Insert(int index, T item)
        {
            if (index >= this.array.Length)
            {
                throw new ArgumentOutOfRangeException("Error! Argument is out of range!");
            }

            bool fl = false;
            if (this.count == this.array.Length)
            {
                Array.Resize(ref this.array, this.array.Length * 2);

                for (int i = (this.array.Length / 2) - 1; i >= index; i--)
                {
                    this.array[i + 1] = this.array[i];
                }

                this.array[index] = item;
                this.count++;

                fl = true;
            }
            else if (this.count < this.array.Length)
            {
                for (int i = this.array.Length - 1; i >= index; i--)
                {
                    this.array[i + 1] = this.array[i];
                }

                this.array[index] = item;
                this.count++;

                fl = true;
            }

            if (fl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
