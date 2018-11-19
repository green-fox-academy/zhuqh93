using System;
using System.Collections.Generic;
using System.Text;

namespace workshop
{
    class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }

        public int CompareTo(Object obj)
        {
            Domino domino = obj as Domino;
            return this.Values[0].CompareTo(domino.Values[0]);
        }
    }
}
