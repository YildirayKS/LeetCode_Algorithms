public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        char[] lettersOfJewels = jewels.ToCharArray();

        char[] lettersOfStones = stones.ToCharArray();

        int counter = 0;

        for (int i = 0; i < lettersOfJewels.Length; i++)
        {
            for (int j = 0; j < lettersOfStones.Length; j++)
            {
                if (lettersOfJewels[i] == lettersOfStones[j])
                {
                    counter++;
                }
            }
        }

        return counter;
    }
}