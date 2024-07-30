using System.Numerics;

public class Solution
{
    public double Average(int[] salary)
    {
        int max = salary.Max();
        int min = salary.Min();
        double answer = 0;

        for (int i = 0; i < salary.Length; i++)
        {
            if (salary[i] == max || salary[i] == min)
            {
                salary[i] = 0;
            }
            else
            {
                answer += salary[i];
            }
        }

        return answer/(salary.Length-2);
    }
}