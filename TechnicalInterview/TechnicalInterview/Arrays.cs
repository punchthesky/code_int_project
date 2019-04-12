using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalInterview
{
    class Arrays
    {
        public int RemoveDuplicates(int[] nums)
        {
            //start after the first number becuase the first will always be unique

            int index = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[index++] = nums[i + 1];

                }
            }

            return index;
        }

        public int BuySellStockMaxProfit(int[] dayValues)
        {
            int profit;


            return profit
        }
    }
  
}
  