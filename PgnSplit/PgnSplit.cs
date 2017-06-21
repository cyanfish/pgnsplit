using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgnSplit
{
    public static class PgnSplit
    {
        public static void Split(string path, long partSize, bool keepOriginal, Func<long, long, bool> progressCallback)
        {
            long bytesWritten = 0;
            long totalBytesWritten = 0;
            long originalSize = new FileInfo(path).Length;
            int i = 0;
            int currentOutputNumber = 0;
            string prevLine = null;
            List<string> outputFiles = new List<string>();
            StreamWriter output = null;
            StreamReader input = new StreamReader(path);
            try
            {
                while (true)
                {
                    if (output == null)
                    {
                        string dir = Path.GetDirectoryName(path);
                        string fileName = Path.GetFileNameWithoutExtension(path) + $".{++currentOutputNumber}.pgn";
                        string outputPath = dir != null ? Path.Combine(dir, fileName) : fileName;
                        outputFiles.Add(outputPath);
                        output = new StreamWriter(outputPath);
                    }
                    string line = input.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    output.WriteLine(line);
                    bytesWritten += line.Length;
                    totalBytesWritten += line.Length;
                    i++;
                    if (bytesWritten > partSize && line.Trim() == "" && prevLine != null && char.IsDigit(prevLine[0]))
                    {
                        // Split to the next file
                        output = null;
                        bytesWritten = 0;
                    }
                    if (i % 1000 == 0 && !progressCallback(totalBytesWritten, originalSize))
                    {
                        // Cancelled
                        output?.Dispose();
                        foreach (var outputPath in outputFiles)
                        {
                            File.Delete(outputPath);
                        }
                        break;
                    }
                    prevLine = line;
                }
            }
            finally
            {
                output?.Dispose();
                input.Dispose();
            }
        }
    }
}
