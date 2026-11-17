/*  Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). Read the details from same file and print on console.
*/

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
      //data to store inside in file
        int age = 22;
        string userName = "Dorian Maize";
        string address = "1236 Ala Kapuna St, Honolulu";

    
        
        // string of the info
        string[] details =
    {
      $"Name: {userName}",
      $"Age: {age}",
      $"Address: {address}"
    };

        // Set a variable to the Documents path.
        string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Write the string array to a new file named "WriteLines.txt".
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
        {
            foreach (string detail in details)
                outputFile.WriteLine(detail);
        }
        string filePath = Path.Combine(docPath, "WriteLines.txt");

        Console.WriteLine("Details read from the file:");

        Console.WriteLine(File.ReadAllText(filePath));

        Console.WriteLine("Press any key to exit..");
        Console.ReadKey();
    }
}



