using System;

namespace FirstCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("get ready for some sigma");
            Console.WriteLine(Sigma(8));
            int[] avgthis = {1,3,5,7,9};
            Console.WriteLine(Avg(avgthis));
        }
        public static int Sigma(int num)
        {
            int sum=0;
            for(int i=1; i<num; i++){
                sum+=i;
            }
            return sum;
        }
        public static int Avg(int[] arr)
        {
            int sum=0;
            for(int i=0; i<arr.Length; i++)
            {
                sum+=arr[i];
            }
            sum/=arr.Length;

            return sum;
        }
    }
}
