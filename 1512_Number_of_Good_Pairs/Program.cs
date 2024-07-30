public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        int answer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = (nums.Length - 1); j > i; j--)
            {
                if (nums[i] == nums[j])
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}