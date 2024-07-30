public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        n = (nums.Length / 2);

        int a = 0;

        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (i%2 == 0)
            {
                result[i] = nums[a];
                a++;
            }
            else
            {
                result[i] = nums[n];
                n++;
            }
        }

        return result;
    }
}