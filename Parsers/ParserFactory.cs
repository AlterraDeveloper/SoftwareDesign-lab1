using SoftwareDesign_lab1.Entities;
using System;

namespace SoftwareDesign_lab1.Parsers
{
    public static class ParserFactory
    {
        public static Parser GetParser(string typeName,Package package)
        {
            if (typeName.Equals("KRSU",StringComparison.OrdinalIgnoreCase))
            {
                return new KrsuParser(package);
            }

            if (typeName.Equals("CATS", StringComparison.OrdinalIgnoreCase))
            {
                return new CatsParser(package);
            }

            if (typeName.Equals("PCMS1", StringComparison.OrdinalIgnoreCase))
            {
                return new Pcms1Parser(package);
            }

            if (typeName.Equals("PCMS2", StringComparison.OrdinalIgnoreCase))
            {
                return new Pcms2Parser(package);
            }

            return null;
        }
    }
}