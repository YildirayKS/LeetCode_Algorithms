public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        int sum = 0;
        int multiple = 1;

        while (n > 0)
        {
            sum += n % 10;
            multiple *= n % 10;

            n = n / 10;
        }

        return (multiple - sum);
    }
}