namespace CriptionAlgorithm;

public class Decryption
{
    string encryptAlphabet = "ЦЕЖЮЗМЛАРШИВГСУЧБЩОДЬХТПЯНКЭФЫ";
    string alphabet = "ОZZZZZZZZZZZZZZZZZZZZZГZZZZZZZ";

    public string DecryptSequence(string sequence)
    {
        string encryptedSequence = "";

        for (int i = 0; i < sequence.Length; i++)
        {
            for (int j = 0; j < encryptAlphabet.Length; j++)
            {
                if (sequence[i] == encryptAlphabet[j])
                {
                    encryptedSequence += alphabet[j];
                }
            }
        }
        return encryptedSequence;
    }
}
