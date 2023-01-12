using System;
using System.IO;

namespace Code_Formatting
{    
    class Program
    {
        public const string FILE_NAME = "example.bin";
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(FILE_NAME, FileMode.CreateNew);

            // Create the writer for data.

            BinaryWriter writer = new BinaryWriter(fileStream);

            // write data to

            for (int i = 0; i < 11; i++)
            {
                writer.Write((int)i);
            }
            writer.Close();
            fileStream.Close();

            // Create the reader for data.

            fileStream = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);

            BinaryReader reader = new BinaryReader(fileStream);

            // Read data from Test.data.

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(reader.ReadInt32());
            }

            reader.Close();
            fileStream.Close();
        }
    }
}
