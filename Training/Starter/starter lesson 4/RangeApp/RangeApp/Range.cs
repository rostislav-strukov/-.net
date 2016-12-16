using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeApp
{
    public sealed class Range<T>
    {
        public T LowerBound { get; private set; }
        public T UpperBound { get; private set; }
        public bool InclusiveLowerBound { get; private set; }
        public bool InclusiveUpperBound { get; private set; }
        public IComparer<T> Comparer { get; private set; }

        public Range(T lowerBound, T upperBound,
                   bool inclusiveLowerBound,
                   bool inclusiveUpperBound,
                   IComparer<T> comparer = null)
        {
            LowerBound = lowerBound;
            UpperBound = upperBound;
            InclusiveLowerBound = inclusiveLowerBound;
            InclusiveUpperBound = inclusiveUpperBound;
            Comparer = comparer ?? Comparer<T>.Default;

            if (Comparer.Compare(LowerBound, UpperBound) > 0)
            {
                throw new ArgumentException("Invalid bounds");
            }
        }

        public bool Contains(T item)
        {
            int lowerCompare = Comparer.Compare(LowerBound, item);
            if (lowerCompare > (InclusiveLowerBound ? 0 : -1))
            {
                Console.WriteLine("flag 1");
                return false;         
            }
            int upperCompare = Comparer.Compare(item, UpperBound);
            if (upperCompare > (InclusiveUpperBound ? 0 : -1))
            {
                Console.WriteLine("flag 2");
                return false;                
            }
            Console.WriteLine($"You are chek in range {LowerBound} to {UpperBound}");
            return true;
        }
    }
}
