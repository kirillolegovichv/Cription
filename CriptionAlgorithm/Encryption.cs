namespace CriptionAlgorithm;

public class Encryption
{
    string alphabet = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЫЬЭЮЯ";
    string encryptAlphabet = "ЦУКЕНГШЩЗХФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";

    public string EncryptSequence(string sequence)
    {
        string encryptedSequence = "";
        sequence = RemoveNonLetterSymbolsAndUpperCase(sequence);

        for (int i = 0; i < sequence.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if(sequence[i] == alphabet[j])
                {
                    encryptedSequence += encryptAlphabet[j];
                }
            }
        }
        return encryptedSequence;
    }

    public string RemoveNonLetterSymbolsAndUpperCase(string sequence)
    {
        string encryptedSequence = "";
        sequence = sequence.ToUpper();
        for (int i = 0; i < sequence.Length; i++)
        {
            for (int k = 0; k < alphabet.Length; k++)
            {
                if (sequence[i] == alphabet[k] | sequence[i] == 'Й' | sequence[i] == 'Ё' | sequence[i] == 'Ъ')
                {
                    if (sequence[i] == 'Й')
                    {
                        encryptedSequence += 'И';
                        break;
                    }
                    else if (sequence[i] == 'Ё')
                    {
                        encryptedSequence += 'Е';
                        break;
                    }
                    else if (sequence[i] == 'Ъ')
                    {
                        encryptedSequence += 'Ь';
                        break;
                    }
                    else
                    {
                        encryptedSequence += sequence[i];
                    }
                }
            }
        }

        return encryptedSequence;
    }
}
