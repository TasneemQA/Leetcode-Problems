public class Solution
{
   public void Rotate(int[] nums, int k)
   {
      int count = 0;
      while (count <= k)
      {
         int temp = nums[nums.Length - 1];
         for (int i = nums.Length - 1; i > 0; i++)
         {
            nums[i] = nums[i - 1];
         }
         nums[0] = temp;
      }
   }
}