using System;
using System.IO;

namespace EncodeWinUTF8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(args[0]))
            {
                Console.WriteLine("Syntax: <path>");
                return;
            }
            foreach (string s in Directory.EnumerateFiles(args[0]))
            {
                if (ValidFilename(s))
                {
                    string[] contents = File.ReadAllLines(s);
                    File.WriteAllLines(s, contents);
                    Console.WriteLine(s);
                }
            }
        }

        private static bool ValidFilename(string s)
        {
            if (s.EndsWith(".txt")) return true;
            return false;
        }
    }
}
