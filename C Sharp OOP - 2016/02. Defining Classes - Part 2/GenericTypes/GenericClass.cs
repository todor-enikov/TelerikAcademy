using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class GenericClass<T> where T : IComparable //task5
    {
        private int capacity = 4;

        private T[] elements;
        private int index;

        public GenericClass()
        {
            this.elements = new T[capacity];
            this.index = 0;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }


        public T[] Elements
        {
            get
            {
                return this.elements;
            }
            set
            {
                this.elements = value;
            }
        }

        public int Index
        {
            get
            {
                return this.index;
            }
            set
            {
                if (index < 0 || index > elements.Length)
                {
                    throw new ArgumentException("The index must be in the range of the List!");
                }
                this.index = value;
            }
        }
        public void AddingElement(T element)
        {
            if (this.Index >= this.elements.Length) //task6
            {
                T[] currentGeneric = elements;
                this.elements = new T[capacity * 2];
                for (int i = 0; i < currentGeneric.Length; i++)
                {
                    elements[i] = currentGeneric[i];
                }

                this.elements[this.index] = element;
                this.Index++;
            }
            else
            {
                this.elements[this.index] = element;
                this.Index++;
            }
        }

        public override string ToString()
        {
            return string.Join(" ", this.elements);
        }
        public void AccesingElement(int index)
        {
            //elements.GetValue(index);
            elements.ElementAt(index);
        }

        public void Remove(int index)
        {
            if (index < 0 || index > elements.Length - 1)
            {
                throw new ArgumentException("There is no such index in the Generic List!");
            }

            for (int i = index; i < elements.Length-1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            T[] currentGeneric = elements;

            this.elements = new T[elements.Length - 1];

            for (int i = 0; i < currentGeneric.Length-1; i++)
            {
                elements[i] = currentGeneric[i];
            }
            this.index--;
        }

        public void InsertElement(int position, T element)
        {
            if (index < 0 || index > elements.Length - 1)
            {
                throw new ArgumentException("There is no such index in the Generic List!");
            }

            if (this.index >= elements.Length)
            {
                T[] currentGeneric = elements;
                elements = new T[elements.Length + 1];
                int i = 0;
                int j = 0;
                while (i < currentGeneric.Length)
                {
                    if (i == position)
                    {
                        elements[j] = element;
                        j++;
                    }
                    elements[j] = currentGeneric[i];
                    j++;
                    i++;
                }
                this.index = j;
            }
            else
            {
                for (int i = elements.Length - 1; i > position; i--)
                {
                    elements[i] = elements[i - 1];
                }
            }
            elements[position] = element;
            this.index++;
        }

        public void Clear()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = default(T);
            }
            this.index = 0;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public T Min() //task7
        {
            T min = elements[0];

            foreach (var element in elements)
            {
                if (element.CompareTo(min)<0)
                {
                    min = element;
                }
            }
            return min;
        }

        public T Max() //task7
        {
            T max = elements[0];
            foreach (var element in elements)
            {
                if (element.CompareTo(max)>0)
                {
                    max = element;
                }
            }
            return max;
        }
    }
}
