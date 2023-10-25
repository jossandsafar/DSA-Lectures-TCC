using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية                                                                            // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            if (start > end)
                return -1;
           
            int mid1 = start + (end - start) / 3;
            int mid2 = end  - (end - start) / 3;
        
            if (arr[mid1] == key)
                return mid1;

            if (arr[mid2] == key)
                return mid2;
     
            if (key < arr[mid1])
                return TernarySearch(arr, key, start, mid1 - 1);

            else if (key > arr[mid2])
                return TernarySearch(arr, key, mid2 + 1, end);

            else
                return TernarySearch(arr, key, mid1 + 1, mid2 - 1);

            
          
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            int result = -1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == key)
                {
                    result = mid;

                    if (is_first)
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
                else if (key < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return result;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            int firstOccure = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            int lastOccure= BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);

            if (firstOccure != -1 && lastOccure!= -1)
            {
                return lastOccure - firstOccure + 1;
            }
            else
            {
               
                return 0;
            }
        }
    }
}
