using System;
using System.IO;
using SoftwareDesign_lab1.Entities;
using SoftwareDesign_lab1.Parsers;
using System.Xml;

namespace SoftwareDesign_lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("usage : program.exe [FORMAT] [PACKAGE]");
            }
            else
            {
                try
                {
                    var package = Package.GetPackage(args[1]);
                    var parser = ParserFactory.GetParser(args[0], package);

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
                catch (XmlException)
                {
                    Console.WriteLine("Bad XML configuration");
                }
                catch (InvalidDataException)
                {
                    Console.WriteLine("File is not ZIP archive");
                }
               
            }
            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}