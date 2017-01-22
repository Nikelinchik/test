using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms.Test
{
    public class BaseTestClass
    {
        #region Protected Properties

        protected MathComputer _mathComputer { get; set; }

        protected SearchComputer _searchComputer { get; set; }

        protected SortComputer _sortComputer { get; set; }

        #endregion

        #region Protected Methods

        protected int[] Init(int count, int? valueFrom = null)
        {
            var result = new int[count];

            if (!valueFrom.HasValue)
            {
                for (int i = 0; i < count; i++)
                {
                    result[i] = i;
                }
            }
            else
            {
                var value = valueFrom.Value;
                for (int i = 0; i < count; i++)
                {
                    result[i] = value;
                    value++;
                }
            }
            return result;
        }

        protected int[] InitWithRange(int count, int searchValue, int? valueFrom = null)
        {
            var result = new int[count];

            var random = new Random();

            var range = Enumerable.Range(0, 300).Where(x => x != searchValue);

            for (int i = 0; i < count - 2; i++)
            {
                var index = random.Next(0, 300 - 1);

                result[i] = range.ElementAt(index);
            }

            result[count - 1] = searchValue;

            return result;
        }

        #endregion
    }
}
