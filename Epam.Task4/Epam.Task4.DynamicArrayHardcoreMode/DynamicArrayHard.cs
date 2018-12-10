using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DynamicArrayHardcoreMode
{
    public class DynamicArrayHard<T> : DynamicArray<T>, ICloneable
    {
        public DynamicArrayHard() : base()
        {
        }

        public DynamicArrayHard(int length) : base(length)
        {
        }

        public DynamicArrayHard(IEnumerable<T> collection) : base(collection)
        {
        }

        public override T this[int index]
        {
            get
            {
                if (index >= array.Length)
                {
                    throw new ArgumentOutOfRangeException("Error! Argument is out of range!");
                }
                else if (index < 0)
                {
                    return this.array[this.count + index];
                }
                else
                {
                    return this.array[index];
                }  
            }
        }

        public void ChangeCapacity(int number)
        {
            Array.Resize(ref this.array, this.array.Length + number);
        }

        public object Clone()
        {
            DynamicArray<T> arrayCopy = new DynamicArray<T>(array.Length);
            for (int i = 0; i < this.array.Length; i++)
            {
                arrayCopy[i] = this.array[i];
            }

            return arrayCopy;
        }

        public T[] ToArray()
        {
            T[] newArray = new T[array.Length];
            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            return newArray;
        }
    }
}
