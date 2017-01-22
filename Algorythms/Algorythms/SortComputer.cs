using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms
{
    //public class SortComputer<T>
    //{
    //    public IEnumerable<T> SelectionSort(IEnumerable<T> sequence)
    //    {            
    //    }
    //}

    public class SortComputer
    {
        public int[] SelectionSort(int[] entryArray)
        {
            for (int i = 0; i < entryArray.Count() - 1; i++)
            {
                var smallest = i;

                for (int j = i + 1; j < entryArray.Count(); j++)
                {
                    if (entryArray[j] < entryArray[smallest])
                    {
                        smallest = j;
                    }
                }
                var temp = entryArray[i];
                entryArray[i] = entryArray[smallest];
                entryArray[smallest] = temp;
            }
            return entryArray;
        }
    }
}
