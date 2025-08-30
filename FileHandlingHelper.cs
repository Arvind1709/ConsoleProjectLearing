using System.Text;

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
        public void Encodings()
        {
            string text = "Hello, Encoding!";

            // Convert string to bytes (Encoding)
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(text);
            Console.WriteLine("UTF-8 Encoded Bytes: " + BitConverter.ToString(utf8Bytes));

            // Convert bytes back to string (Decoding)
            string decodedText = Encoding.UTF8.GetString(utf8Bytes);
            Console.WriteLine("Decoded Text: " + decodedText);

            // Try with ASCII Encoding
            byte[] asciiBytes = Encoding.ASCII.GetBytes(text);
            string asciiDecoded = Encoding.ASCII.GetString(asciiBytes);
            Console.WriteLine("ASCII Decoded Text: " + asciiDecoded);
        }

        public void ReadWriteWithEncodingAndDecoding()
        {
            //string filePathToRead = @"C:\\Users\\Dell\\Desktop\\StringOperation\\MOD'ELLE_3597_20241204190045.dat";
            //string filePathToWrite = @"C:\\Users\\Dell\\Desktop\\StringOperation\\example.txt";
            string filePath = @"C:\\Users\\Dell\\Desktop\\StringOperation\\ReadWriteWithEncodingAndDecoding.txt";
            string originalText = "Hello, Encoding Example! 😊";

            // --- Save text to file with UTF-8 Encoding ---
            byte[] encodedBytes = Encoding.UTF8.GetBytes(originalText);
            File.WriteAllBytes(filePath, encodedBytes);
            Console.WriteLine("Text saved to file using UTF-8 encoding.");

            // --- Read text from file with UTF-8 Encoding ---
            byte[] readBytes = File.ReadAllBytes(filePath);
            var demo = File.ReadAllLines(filePath);
            string decodedText = Encoding.UTF8.GetString(readBytes);
            Console.WriteLine("Decoded text from file: " + decodedText);


            // --- Save text to file with ASCII Encoding ---
            string asciiFilePath = "ascii_example.txt";
            byte[] asciiBytes = Encoding.ASCII.GetBytes(originalText);
            File.WriteAllBytes(asciiFilePath, asciiBytes);
            Console.WriteLine("Text saved to file using ASCII encoding.");

            // --- Read text from file with ASCII Encoding ---
            byte[] readAsciiBytes = File.ReadAllBytes(asciiFilePath);
            string decodedAsciiText = Encoding.ASCII.GetString(readAsciiBytes);
            Console.WriteLine("Decoded text from ASCII file: " + decodedAsciiText);
        }
    }
}
