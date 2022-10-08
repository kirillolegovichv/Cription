using CriptionAlgorithm;

Encryption enc = new Encryption();
Decryption dec = new Decryption();

string seq = Console.ReadLine();

Console.WriteLine(enc.EncryptSequence(seq));
string text = Console.ReadLine();
Console.WriteLine(dec.DecryptSequence(text));