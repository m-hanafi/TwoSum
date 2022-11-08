using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //get the number array from user input
            //array example: {2,7,11,15}
            Console.WriteLine("Enter number array (i.e: '2,7,11,15')");
            int[] nums = Array.ConvertAll(Console.ReadLine().Trim().Split(','),Convert.ToInt32);
           
            //get the target from user input
            Console.WriteLine("Enter target:"); 
            int target = Convert.ToInt32(Console.ReadLine());

            // execute TwoSum function to get the indices

            //Using brute force to iterate through for loop
            //int[] res = TwoSum(nums, target);

            //Search through dictionary  
            int[] res = TwoSum_2(nums, target);
            if (res!=null)
            {
                Console.WriteLine($"res: [{string.Join(", ", res)}]"); //print the result of the indices
            }
            else
            {
                Console.WriteLine("No result!"); //print if result is null
            }
        }

        //Brute Force
        public static int[] TwoSum(int[] nums, int target) {

            //iterate using for loop to get the array element
            for(int i = 0; i<nums.Length-1;i++){
                int num2 = target - nums[i]; //get the result after target - array element
                for(int j=i+1;j<nums.Length;j++){ //iterate using for loop to match the result with the next array element
                    if(nums[j]==num2){
                        return new int[]{i,j}; //return the indices if the result matched with the next array element.                      
                    }
                }
            }
            return null; //return if no indices matched.
        }

        //Search the value through a dictionary
        public static int[] TwoSum_2(int[] nums, int target) {

            Dictionary<int,int> dict = new Dictionary<int,int>();

            //iterate through nums array
            for (int i=0;i<nums.Length;i++)
            {
                int num2 = target - nums[i]; //get the 2nd value
                if (dict.ContainsKey(num2)) //if the 2nd value exist in dictionary key
                {
                    return new int[]{i,dict[num2]}; //return the indices if the result matched with the next array element.                               
                }
                else //if the 2nd value not exist in dictionary key
                {
                    dict.Add(nums[i],i); //add the current value into dictionary
                }                    
            }  
            return null;                            
        }
    }
}
