using CriptionAlgorithm;

Encryption enc = new Encryption();
Decryption dec = new Decryption();
FrequencyOfOccurringCharacters fr = new FrequencyOfOccurringCharacters();
Dictionary<char, int> dict = new Dictionary<char, int>();

//string seq = Console.ReadLine();
//seq = seq.ToUpper();
//Console.WriteLine(enc.EncryptSequence(seq));

string text = Console.ReadLine();
text = text.ToUpper();
Console.WriteLine(text);
Console.WriteLine(dec.DecryptSequence(text));

//dict = fr.CountingFrequencyOfOccurringCharacters(seq);
//foreach(var c in dict)
//{
//    Console.WriteLine($"key: {c.Key} value {c.Value}");
//}