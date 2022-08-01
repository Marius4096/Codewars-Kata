using System;

namespace Count_by_X
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(string.Join("," ,CountBy(1, 5)));
            Console.WriteLine(string.Join(",", CountBy(2, 5)));
        }
        public static int[] CountBy(int x, int n)
        {
            int x1 = x;
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] += x1;
                x1 += x;
            }
            return arr;
        }
    }
}
/*
 
 public static int[] CountBy(int x, int n)
  {
    return Enumerable.Range(1, n).Select(i => i * x).ToArray();    
  }
 
public static int[] CountBy(int x, int n)
  {
    return Enumerable.Range(1, n).Select(e => e * x).ToArray();
  }

 */