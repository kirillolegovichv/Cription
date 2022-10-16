namespace CriptionAlgorithm;

public class FrequencyOfOccurringCharacters
{
    public void CountingFrequencyOfOccurringCharacters(string sequence)
    {
        Dictionary<char, int> characters = new Dictionary<char, int>();
        for(int i = 0; i < sequence.Length; i++)
        {
            if (!characters.ContainsKey(sequence[i]))
            {
                characters.Add(sequence[i], 1);
            }
            else
            {
                characters[sequence[i]]++;
            }
        }
    }
}
