public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int n = nums.Length;

        int[] newNums = new int[n];

        for (int i = 0; i < n; i++)
        {
            newNums[i] = nums[nums[i]];
        }

        return newNums;
    }
}