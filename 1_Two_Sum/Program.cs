public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] answer = new int[2];
        int sum = 0;
        bool isFound = false;
        for (int i = 0; i < nums.Length; i++)
        {
            if (isFound == false)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[i] + nums[j];

                    if (sum == target)
                    {
                        answer[0] = i;
                        answer[1] = j;
                        isFound = true;
                        break;
                    }
                    sum = 0;
                }
            }
            else
            {
                break;
            } 
        }
        return answer;
    }
}