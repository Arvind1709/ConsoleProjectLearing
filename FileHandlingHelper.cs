using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLearing
{
    public class FileHandlingHelper
    {
        public void ReadFile()
        {
            string filePathToRead = @"C:\\Users\\Dell\\Desktop\\StringOperation\\MOD'ELLE_3597_20241204190045.dat";
            string filePathToWrite = @"C:\\Users\\Dell\\Desktop\\StringOperation\\example.txt";
            try
            {
                // Check if file exists
                if (File.Exists(filePathToRead))
                {
                    // Open the file and read all lines
                    string[] lines = File.ReadAllLines(filePathToRead);

                    Console.WriteLine("Contents of the .dat file:");
                    using (StreamWriter writer = new StreamWriter(filePathToWrite))
                    foreach (var line in lines)
                    {
                       Console.WriteLine(line);
                       writer.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
        }
    }
}
