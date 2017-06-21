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
            int lineIndex = 0;
            int outputFileNumber = 1;
            List<string> outputFiles = new List<string>();
            StreamWriter output = null;
            StreamReader input = new StreamReader(path);
            long gameLength = 0;
            bool gameHasMoves = false;
            List<string> gameBuffer = new List<string>();
            try
            {
                while (true)
                {
                    string line = input.ReadLine();
                    if (line != null)
                    {
                        gameBuffer.Add(line);
                        gameLength += line.Length;
                        if (line.Length > 0 && char.IsDigit(line[0]))
                        {
                            gameHasMoves = true;
                        }
                    }
                    if (string.IsNullOrWhiteSpace(line) && gameHasMoves)
                    {
                        // Flush the game buffer
                        if (output == null || bytesWritten + gameLength > partSize)
                        {
                            // Split to the next file
                            output?.Dispose();
                            string dir = Path.GetDirectoryName(path);
                            string fileName = Path.GetFileNameWithoutExtension(path) + $".{outputFileNumber++}.pgn";
                            string outputPath = dir != null ? Path.Combine(dir, fileName) : fileName;
                            outputFiles.Add(outputPath);
                            output = new StreamWriter(outputPath);
                            bytesWritten = 0;
                        }
                        foreach (var bufferedLine in gameBuffer)
                        {
                            output.Write(bufferedLine);
                            output.Write('\n');
                            bytesWritten += bufferedLine.Length + 1;
                            totalBytesWritten += bufferedLine.Length + 1;
                        }
                        gameBuffer.Clear();
                        gameLength = 0;
                        gameHasMoves = false;
                    }
                    if (line == null)
                    {
                        break;
                    }
                    lineIndex++;
                    if (lineIndex % 1000 == 0 && !progressCallback(totalBytesWritten, originalSize))
                    {
                        // Cancelled
                        output?.Dispose();
                        foreach (var outputPath in outputFiles)
                        {
                            File.Delete(outputPath);
                        }
                        return;
                    }
                }
                if (!keepOriginal)
                {
                    input.Dispose();
                    File.Delete(path);
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
