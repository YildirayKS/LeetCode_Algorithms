public class Solution
{
    public int CommonFactors(int a, int b)
    {
        List<int> commonFactors = new List<int>();

        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                commonFactors.Add(i);
            }
        }
        return commonFactors.Count();
    }
}