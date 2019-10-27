using System.Diagnostics;
using SoftwareDesign_lab1.Enums;

namespace SoftwareDesign_lab1.Entities
{
    public class ExistenceValidator : Validator
    {
        protected Package _package;

        public ExistenceValidator(Package package)
        {
            _package = package;
        }

        public override ValidationResultMessage Validate(ConfigurationParameter configurationParameter)
        {
            var message = new ValidationResultMessage
            {
                Body = configurationParameter.Name
            };

            var xNode = _package.Configuration.DocumentElement?.SelectSingleNode(configurationParameter.Name);
            
            if (xNode == null)
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
            else
            {
                message.Status = StatusWords.OK;
            }

            return message;
        }
    }
}