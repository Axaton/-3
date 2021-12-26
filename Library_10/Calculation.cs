using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryMatrix;

namespace Library_10
{
    public static class Calculation
    {
        public static (int index , int multiply) MinimalNumber(MyMatrix myarray)
        {
            int resultMultiply = int.MaxValue;
            int indexColumn = 0;

            for (int i = 0; i < myarray.ColumnLength; i++)
            {
                int multiplication = 1;
                for (int j = 0; j < myarray.RowLength; j++)
                {
                    multiplication *= myarray[j, i];
                }
                if (resultMultiply > multiplication)
                {
                    resultMultiply = multiplication;
                    indexColumn = i;
                }
            }
            var result = (indexColumn, resultMultiply);
            return result;
        }
    }
}
