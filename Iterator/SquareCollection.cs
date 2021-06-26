using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class SquareCollection : IEnumerable<int>
    {
        private int[][] items;
        public SquareCollection(int number)
        {
            Random rand = new Random();
            this.items = new int[number][];
            for (int i = 0; i < number; i++)
            {
                int[] item = new int[number];
                for (int j = 0; j < number; j++)
                {
                    item[j] = rand.Next() % 10;
                }
                this.items[i] = item;
            }
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = items[i].Length - 1; j >= 0; j--)
                {
                    yield return items[i][j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
