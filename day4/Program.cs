
namespace day4
{
    using System;
    using System.Threading.Channels;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the array: ");
            string input = Console.ReadLine();
            string[] nums_strr = input.Split(',');
            int[] nums = new int[nums_strr.Length];
            for (int i = 0; i < nums_strr.Length; i++)
            {
                nums[i] = int.Parse(nums_strr[i]);
            }
            int[] products = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i)
                        product *= nums[j];
                }
                products[i] = product;
            }
            Console.Write('(');
            for (int i = 0; i < nums.Length;i++) {
                    Console.Write(products[i]);
                    Console.Write(',');
                }
            Console.Write(')');
        }

    }
}
    

