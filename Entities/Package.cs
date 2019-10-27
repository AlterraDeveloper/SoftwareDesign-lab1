using System.IO;
using System.Xml;

namespace SoftwareDesign_lab1.Entities
{
    public class Package
    {
        private static Package _package = null;

        private Package(string pathToPackage)
        {
            PackageDirectoryInfo = new DirectoryInfo(pathToPackage);
            
            var xmlFilesInPackage = PackageDirectoryInfo.GetFiles("*.xml");
            
            if (xmlFilesInPackage.Length == 1)
            {
                Configuration = new XmlDocument();
                Configuration.Load(xmlFilesInPackage[0].FullName);
            }
            else
            {
                Configuration = null;
            }
           
        }

        public DirectoryInfo PackageDirectoryInfo { get; set; }
        public XmlDocument Configuration { get; set; }

        public static Package GetPackage(string pathToPackage)
        {
            if (_package == null || _package.PackageDirectoryInfo.FullName != pathToPackage)
            {
                if (Directory.Exists(pathToPackage))
                {
                    _package = new Package(pathToPackage);
                }
            }

            return _package;
        }
    }
}