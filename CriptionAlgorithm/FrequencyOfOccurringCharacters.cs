namespace CriptionAlgorithm;

public class FrequencyOfOccurringCharacters
{
    public void CountingFrequencyOfOccurringCharacters(string sequence)
    {
        Dictionary<string, int> characters = new Dictionary<string, int>();
        for(int i = 0; i < sequence.Length; i++)
        {
            if (!characters.ContainsKey(sequence[i].ToString()))
            {
                characters.Add(sequence[i].ToString(), 1);
            }
            else
            {
                characters[sequence[i].ToString()]++;
            }
        }
    }
}
