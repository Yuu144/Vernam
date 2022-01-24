using System;
using System.IO;

class Program
{
    private static void Main()
    {
        string key = "asdf";
        string message = "this is a test message";
        string encrypted = encrypt(message, key);
        string decrypted = decrypt(encrypted, key);

        Console.WriteLine("Verschlüsselt:");
        Console.WriteLine(encrypted);

        Console.WriteLine("");

        Console.WriteLine("Entschlüsselt:");
        Console.WriteLine(decrypted);

        Console.ReadLine();
    }

    private static string encrypt(string message, string key)
    {
        string encrypted = null;
		
	Console.WriteLine(key.Length);

	int j = 0;
        for (int i = 0; i < message.Length; i++)
        {
	    j++;

            if (j == key.Length)
                j = 0;

            encrypted += (char)((int)message[i] + (int)key[j]);
        }

        return encrypted;
    }

    private static string decrypt(string encrypted, string key)
    {
        string decrypted = null;

	int j = 0;
        for (int i = 0; i < encrypted.Length; i++)
        {
	    j++;

            if (j == key.Length)
                j = 0;

            decrypted += (char)((int)encrypted[i] - (int)key[j]);
        }

        return decrypted;
    }
}
