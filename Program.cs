using System;
using SoftwareDesign_lab1.Entities;
using SoftwareDesign_lab1.Parsers;

namespace SoftwareDesign_lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("usage : program.exe [FORMAT] [PACKAGE]");
            }
            else
            {
                var package = Package.GetPackage(args[1]);
                var parser = ParserFactory.GetParser(args[0],package);
                
                if (parser != null)
                {                   
                    var result = parser.Parse();
                    parser.ShowResult(result);
                }
                else
                {
                    Console.WriteLine("Parser not found");
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}