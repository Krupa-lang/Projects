using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    public abstract class BubbleSorterAb
    {
        private int operations = 0;
        protected int length = 0;

        protected int DoSort()
        {
            operations = 0;
            if (length <= 1)
            {
                return operations;
            }

            for (int nextToLast = length - 2;
                nextToLast > 0 ; nextToLast--)
            {
                for (int index = 0; index <= nextToLast; index++)
                {
                    if (OutOfOrder(index))
                    {
                        Swap(index);
                    }
                    operations++;
                }
            }
            return operations;
        }

        protected abstract void Swap(int index);
        protected abstract bool OutOfOrder(int index);
    }
}
