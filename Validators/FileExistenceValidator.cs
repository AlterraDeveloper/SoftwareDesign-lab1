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
            return Package.PackageZipArchive.GetEntry(value) != null;
        }
    }
}