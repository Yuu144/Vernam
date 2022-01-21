using System;
using System.IO;

class Program
{
    private static void Main()
    {
        string key = "test";
        string message = File.ReadAllText("test.txt");
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

        for (int i = 0; i < message.Length; i++)
        {
            int j = i;

            if (j >= key.Length)
                j = 0;

            encrypted += (char)((int)message[i] + (int)key[j]);
        }

        return encrypted;
    }

    private static string decrypt(string encrypted, string key)
    {
        string decrypted = null;

        for (int i = 0; i < encrypted.Length; i++)
        {
            int j = i;

            if (j >= key.Length)
                j = 0;

            decrypted += (char)((int)encrypted[i] - (int)key[j]);
        }

        return decrypted;
    }
}
