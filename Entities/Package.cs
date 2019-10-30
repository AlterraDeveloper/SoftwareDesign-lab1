using System;
using System.IO;
using System.Xml;
using System.IO.Compression;

namespace SoftwareDesign_lab1.Entities
{
    public class Package
    {
        private static Package _package = null;

        private Package(string pathToPackage)
        {
            using (PackageZipArchive = new ZipArchive(new FileStream(pathToPackage, FileMode.Open), ZipArchiveMode.Read))
            {
                foreach (var zipArchiveEntry in PackageZipArchive.Entries)
                {
                    if (zipArchiveEntry.FullName.EndsWith("xml"))
                    {
                        Configuration = new XmlDocument();
                        Configuration.Load(zipArchiveEntry.Open());
                    }
                }
            }
        }

        public ZipArchive PackageZipArchive { get; set; }
        public XmlDocument Configuration { get; set; }

        public static Package GetPackage(string pathToPackage)
        {
            if (_package == null )
            {
                if (File.Exists(pathToPackage))
                {
                    _package = new Package(pathToPackage);
                }
            }

            return _package;
        }
    }
}