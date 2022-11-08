using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] nums = new int[] {2,7,11,15};
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
