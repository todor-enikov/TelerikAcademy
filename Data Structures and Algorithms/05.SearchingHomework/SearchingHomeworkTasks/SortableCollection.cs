namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public bool LinearSearch(T item)
        {
            var isFindElement = false;
            foreach (T element in this.Items)
            {
                if (element.CompareTo(item) == 0)
                {
                    isFindElement = true;
                    break;
                }
            }

            return isFindElement;
        }

        public bool BinarySearch(T item)
        {
            var from = 0;
            var to = this.Items.Count;

            while (from <= to)
            {
                int middle = (from + to) / 2;
                if (this.Items[middle].CompareTo(item) < 0)
                {
                    from = middle + 1;
                }
                else if (this.Items[middle].CompareTo(item) > 0)
                {
                    to = middle - 1;
                }
                else if (this.Items[middle].CompareTo(item) == 0)
                {
                    return true; 
                }
            }

            return false;
        }

        public void Shuffle()
        {
            var random = new Random();
            for (int i = 0; i < this.Items.Count; i++)
            {
                var randomIndex = i + random.Next(0, this.Items.Count - i);
                var temp = this.items[i];
                this.items[i] = this.items[randomIndex];
                this.items[randomIndex] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
