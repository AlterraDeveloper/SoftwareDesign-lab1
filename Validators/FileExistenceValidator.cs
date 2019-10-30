using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using SoftwareDesign_lab1.Enums;
using SoftwareDesign_lab1.Validators;

namespace SoftwareDesign_lab1.Entities
{
    public class FileExistenceValidator : ValueValidator
    {
        public FileExistenceValidator(Package package) : base(package)
        {
        }

        protected override bool CheckValue(string value)
        {
            return _package.PackageZipArchive.GetEntry(value) != null;
        }
    }
}