using System;

namespace TechnicalInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayProblem = new Arrays();
            int[] nums = { 1,1,2};
            int len = arrayProblem.RemoveDuplicates(nums);

            Console.WriteLine(len);

        }
    }
}
