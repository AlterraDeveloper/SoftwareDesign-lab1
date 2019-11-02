using System.Text.RegularExpressions;
using SoftwareDesign_lab1.Entities;

namespace SoftwareDesign_lab1.Validators
{
    class FileRangeValidator  : ValueValidator
    {
        private readonly int _leftBound;
        private readonly int _rightBound;

        public FileRangeValidator(Package package,string paramName) : base(package)
        {
            var confParam = GetConfigurationParameters(new ConfigurationParameter {Name = paramName})[0];
            _leftBound = int.Parse(confParam.Attributes["from"].Value);
            _rightBound = int.Parse(confParam.Attributes["to"].Value);
        }

        protected override bool CheckValue(string value)
        {
            bool validationResult = true;
            var numberLen = _rightBound.ToString().Length;
            for (int i = _leftBound; i <= _rightBound; i++)
            {
                var filePath = Regex.Replace(value, "%0n", i.ToString().PadLeft(numberLen,'0'));
                validationResult &= Package.PackageZipArchive.GetEntry(filePath) != null;
            }
            return validationResult;
        }
    }
}
