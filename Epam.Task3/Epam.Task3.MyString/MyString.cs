using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MyString
{
   public class MyString
    {
        private char[] charArray;

        public MyString(int length)
        {
            this.charArray = new char[length];
        }

        public char this[int index]
        {
            get
            {
                return this.charArray[index];
            }

            set
            {
                this.charArray[index] = value;
            }
        }

        public void ShowCharArray()
        {
            foreach (char symbol in this.charArray)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }

       public int MyLength()
        {
                int length = 0;
                foreach (char symbol in this.charArray)
                {
                    length++;
                }

                return length;
        }

        public int MyIndexOf(char symbol)
        {
            int index = -1;
            for (int i = 0; i < this.charArray.Length; i++)
            {
                if (this.charArray[i] == symbol)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public int MyLastIndexOf(char symbol)
        {
            int index = -1;
            for (int i = this.charArray.Length - 1; i > -1; i--)
            {
                if (this.charArray[i] == symbol)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public char[] MyConcat(MyString str2)
        {
            int firstLength = this.charArray.Length;
            int length = this.charArray.Length + str2.MyLength();
            Array.Resize(ref this.charArray, length);
            for (int i = firstLength, j = 0; i < length && j < str2.MyLength(); i++, j++)
            {
                this.charArray[i] = str2[j];
            }

            return this.charArray;
        }

        public int MyCompare(MyString str2)
        {
            int firstLength = this.charArray.Length;
            int secondLength = str2.MyLength();
            if (firstLength > secondLength)
            {
                return 1;
            }
            else if (firstLength < secondLength)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public void MyDelete(char symbol)
        {
            for (int i = 0; i < this.charArray.Length; i++)
            {
                if (this.charArray[i] == symbol)
                {
                    for (int j = i; j < this.charArray.Length - 1; j++)
                    {
                        this.charArray[j] = this.charArray[j + 1];
                    }

                    Array.Resize(ref this.charArray, this.charArray.Length - 1);
                }
            }
        }

        public void MyInsert(char symbol, int pos)
        {
            Array.Resize(ref this.charArray, this.charArray.Length + 1);
            for (int i = this.charArray.Length - 2; i >= pos; i--)
            {
                this.charArray[i + 1] = this.charArray[i];
            }

            this.charArray[pos] = symbol;
        }

        public StringBuilder MyToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.charArray.Length; i++)
            {
                sb.Append(this.charArray[i]);
            }

            return sb;
        }

        public char[] MyToCharArray(StringBuilder sb)
        {
            int length = sb.Length;
            this.charArray = new char[length];
            for (int i = 0; i < length; i++)
            {
                this.charArray[i] = sb[i];
            }

            return this.charArray;
        }
   }
}
