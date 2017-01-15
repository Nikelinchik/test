using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms
{
    public class Search
    {
        public int LinearSearch(int[] entryArray, int searchValue)
        {
            int result = -1; // not found

            for (int i = 0; i < entryArray.Length; i++)
            {
                if (entryArray[i] == searchValue)
                    result = entryArray[i];
            }

            return result;
        }
    }
}
