using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementVisualApplication
{
    class merge_sort
    {
        static public void MainMerge(int[] numbers, int left, int mid, int right,int count)

        {

            int[] temp = new int[count];

            int i, eol, num, pos;



            eol = (mid - 1);

            pos = left;

            num = (right - left + 1);



            while ((left <= eol) && (mid <= right))

            {

                if (numbers[left] <= numbers[mid])

                    temp[pos++] = numbers[left++];

                else

                    temp[pos++] = numbers[mid++];

            }



            while (left <= eol)

                temp[pos++] = numbers[left++];



            while (mid <= right)

                temp[pos++] = numbers[mid++];



            for (i = 0; i < num; i++)

            {

                numbers[right] = temp[right];

                right--;

            }

        }



        static public void SortMerge(int[] numbers, int left, int right,int count)

        {

            int mid;



            if (right > left)

            {

                mid = (right + left) / 2;

                SortMerge(numbers, left, mid,count);

                SortMerge(numbers, (mid + 1), right, count);



                MainMerge(numbers, left, (mid + 1), right,count);

            }

        }
    }
}
