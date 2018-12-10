using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4.DynamicArrayHardcoreMode
{
    public class CycledDynamicArray<T> : DynamicArray<T>, IEnumerable<T>
    {
        private int countNum = 0;

        public CycledDynamicArray() : base()
        {
        }

        public CycledDynamicArray(int length) : base(length)
        {
        }

        public CycledDynamicArray(IEnumerable<T> collection) : base(collection)
        {
        }

        public override IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= this.array.Length; i++)
            {
                if (i == this.array.Length)
                {
                    i = 0;
                    this.countNum++;
                }

                if (this.countNum < 3)
                {
                    yield return this.array[i];
                }
                else
                {
                    break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
