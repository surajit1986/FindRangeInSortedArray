using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace FindRangeInSortedArray
{
    internal class FindRange
    {
        public int[] FindRangeFunc(int[] arr, int target)
        {
            int firstInd;
            int lastInd;

            if(arr.Length > 0)
            {
                firstInd = FindFirstIndex(arr, target);
                lastInd = FindLastIndex(arr,target);

                return new int[] {firstInd, lastInd };
            }


            return new int[] { - 1, -1};
        }

        private int FindFirstIndex(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid = 0;

            while(left<=right)
            {
                mid = (left+right)/2;

                if (arr[mid] == target)
                {
                    if((mid ==0) || (arr[mid-1] != target))
                    {
                        return mid;
                    }
                    right = mid - 1;
                }
                else if (arr[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

            }

            return -1;
        }

        private int FindLastIndex(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    if ((mid == (arr.Length-1)) || (arr[mid + 1] != target))
                    {
                        return mid;
                    }
                    left = mid + 1;
                }
                else if (arr[mid] > target)
                {
                    right = mid -1;
                }
                else
                {
                    left = mid + 1;
                }

            }

            return -1;
        }
    }
}
