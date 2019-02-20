using System;
using System.Text;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            string str = number.ToString();
            int[] arr = new int[str.Length];
            int i, j;
            int n = str.Length;

            for (i = 0; i < n; i++)
            {
                arr[i] = int.Parse(str[i].ToString());

            }

            for (i = n - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1])
                    break;
            }

            if (i == 0)
                return 0;

            int x = arr[i - 1];
            int s = arr[i];


            //find smallest
            for (j = i ; j < n; j++)
            {
                if (arr[j] > x && arr[j] < s)
                    s = arr[j];
            }

            //place s to the left of x
            int tmp = arr[i - 1];
            arr[i - 1] = s;
            arr[i] = tmp;

            //sort
            int t;
            for (int f = i ; f < n - 1; f++)
            {
                for (int r = i; r < n; r++)
                {
                    if (arr[f] > arr[r])
                    {
                        t = arr[f];
                        arr[f] = arr[r];
                        arr[r] = t;
                    }
                }

            }

            StringBuilder sb = new StringBuilder();
            for (int g = 0; g < n; g++)
            {
                sb.Append(arr[g]);
            }
            string strNew = sb.ToString();
            int m = int.Parse(strNew);
            return m;

        }
    }
}
    
