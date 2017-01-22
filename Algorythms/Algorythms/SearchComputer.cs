using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms
{
    public class SearchComputer
    {
        public int LinearSearch(int[] entryArray, int searchValue)
        {
            for (int i = 0; i < entryArray.Length; i++)
            {
                if (entryArray[i] == searchValue)
                {
                    return i;
                }
            }

            throw new Exception("Not Found");
        }

        public int BinarySearch(int[] entryArray, int searchValue)
        {
            var p = 0;
            var r = entryArray.Length - 1;

            while (p <= r)
            {
                var q = (p + r) / 2;
                if (searchValue == entryArray[q])
                {
                    return q;
                }
                else if (searchValue < entryArray[q])
                {
                    r = q - 1;
                }
                else
                {
                    p = q + 1;
                }
            }
            throw new Exception("Not Found");
        }

        //public int SentinelLinearSearch(int[] entryArray, int searchValue)
        //{
        //    var result = -1;
        //    var i = 0;
        //    var n = entryArray.Length + 1;

        //    var arrayWithSentinel = new int[n];

        //    //Array.Copy(entryArray, arrayWithSentinel, entryArray.Length);
        //    Array.Resize(ref entryArray, entryArray.Count() + 1);

        //    arrayWithSentinel[n - 1] = searchValue;

        //    while (true)
        //    {
        //        if (arrayWithSentinel[i] == searchValue)
        //        {
        //            result = i;
        //            break;
        //        }
        //        i++;
        //    }

        //    if (i < (n - 1))
        //        return result;

        //    else return -1;

        //}
    }
}
