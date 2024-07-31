public class Solution
{    public int MaximumWealth(int[][] accounts)
    {
        int maxSum = 0;
        int temp = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            for (int j = 0; j < accounts[i].Length; j++)
            {
                temp += accounts[i][j];
            }

            if (maxSum < temp)
            {
                maxSum = temp;
            }

            temp = 0;
        }
        return maxSum;
    }
}