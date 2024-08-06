public class Solution
{
    public int NumberOfMatches(int n)
    {
        int match, advantage, round = 0, totalMatch = 0;

        while (n > 1)
        {
            if (n % 2 == 0)
            {
                match = (n / 2);
                advantage = (n / 2);
                n = advantage;
                round++;
            }
            else
            {
                match = (n - 1) / 2;
                advantage = ((n - 1) / 2) + 1;
                n = advantage;
                round++;
            }
            totalMatch += match;
        }

        return totalMatch;
    }
}