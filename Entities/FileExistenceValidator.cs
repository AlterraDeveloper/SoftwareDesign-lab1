using System.IO;
using SoftwareDesign_lab1.Enums;

namespace SoftwareDesign_lab1.Entities
{
    public class FileExistenceValidator : ExistenceValidator
    {
        public FileExistenceValidator(Package package) : base(package)
        {
        }

        public override ValidationResultMessage Validate(ConfigurationParameter configurationParameter)
        {
            var message =  base.Validate(configurationParameter);

            if (message.Status != StatusWords.OK)
            {
                return message;
            }

            if (new DirectoryInfo(Path.Combine(_package.PackageDirectoryInfo.FullName, configurationParameter.Name))
                .Exists)
            {
                message.Status = StatusWords.OK;
            }
            else
            {
                if (configurationParameter.IsRequired)
                {
                    message.Status = StatusWords.ERR;
                }
                else
                {
                    message.Status = StatusWords.WARN;
                }
            }

            return message;
        }
    }
}