using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
           //array example: {2,7,11,15}
           Console.WriteLine("Enter number array (i.e: '2,7,11,15' )");
           int[] nums = Array.ConvertAll(Console.ReadLine().Trim().Split(','),Convert.ToInt32);
           int target = 9;
           TwoSum(nums, target);
        
        }

        public static int[] TwoSum(int[] nums, int target) {
            for(int i = 0; i<nums.Length-1;i++){
                int num2 = target - nums[i];
                for(int j=i+1;j<nums.Length-1;j++){
                    if(nums[j]==num2){
                        Console.WriteLine($"{i},{j}");
                        return new int[]{i,j};                       
                    }
                }
            }
            return new int[2];
        }
    }
}
