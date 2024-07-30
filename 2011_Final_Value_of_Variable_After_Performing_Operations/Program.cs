public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int length = operations.Length;
        int answer = 0;

        for (int i = 0; i < operations.Length; i++)
        {
            if (operations[i] == "++X" || operations[i] == "X++")
            {
                answer++;
            }
            else if (operations[i] == "--X" || operations[i] == "X--")
            {
                answer--;
            }
        }

        return answer;
    }
}