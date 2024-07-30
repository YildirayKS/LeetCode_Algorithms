using System.Formats.Asn1;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] answer = nums;
        int sum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            sum += nums[i];

            for (int j = 0; j < nums.Length; j++)
            {
                answer[i] = sum;
            }
        }

        return answer;
    }
}