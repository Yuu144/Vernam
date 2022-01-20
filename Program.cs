using System;
using System.IO;

class Program
{
    private static void Main()
    {
        string key = "test";
        string message = File.ReadAllText("test.txt");
        string encrypted = null;
        string decrypted = null;

        for(int i = 0; i < message.Length; i++)
        {
            int j = i;

            if (j >= key.Length)
                j = 0;

            encrypted += (char)((int)message[i] + (int)key[j]);
        }

        for (int i = 0; i < message.Length; i++)
        {
            int j = i;

            if (j >= key.Length)
                j = 0;

            decrypted += (char)((int)encrypted[i] - (int)key[j]);
        }

        Console.WriteLine(encrypted);
        Console.WriteLine(decrypted);
        Console.ReadLine();
    }
}