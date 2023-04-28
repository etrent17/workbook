using System;
using System.IO;
using System.Security.Cryptography;

public class fileScanPro
{
    public static void startScanner()
    {
        Console.Write("Enter the file path: ");
        string filePath = null;
        while (filePath == null)
        {
            Console.WriteLine("Enter the file path: ");
            filePath = Console.ReadLine();
            if (filePath == null)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

        if (File.Exists(filePath))
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = sha256.ComputeHash(stream);
                    Console.WriteLine("SHA256 hash of file {0} is: {1}", Path.GetFileName(filePath), BitConverter.ToString(hash).Replace("-", ""));
                }
            }
        }

        else{
            Console.WriteLine("File not found.");
        }

        Console.ReadLine();

        
    }
}