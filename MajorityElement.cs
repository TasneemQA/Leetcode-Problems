public class Solution
{
   public int MajorityElement(int[] nums)
   {
      int count = 0;
      int result = 0;

      for (int i = 0; i < nums.Length; i++)
      {
         if (count == 0)
         {
            result = nums[i];
         }
         count += (nums[i] == result) ? 1 : -1;
      }
      return result;
   }
}
