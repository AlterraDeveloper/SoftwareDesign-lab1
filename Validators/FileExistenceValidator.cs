using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using SoftwareDesign_lab1.Enums;
using SoftwareDesign_lab1.Validators;

namespace SoftwareDesign_lab1.Entities
{
    public class FileExistenceValidator : ExistenceValidator
    {
        public FileExistenceValidator(Package package) : base(package)
        {
        }

        public override IEnumerable<ValidationResultMessage> Validate(ConfigurationParameter configurationParameter)
        {
            var messages = base.Validate(configurationParameter).ToList();

            if (messages.All(m => m.Status == StatusWords.OK) == false)
            {
                return messages;
            }

            messages.Clear();

            if (_package.Configuration.DocumentElement != null)
            {
                var xNodes = _package.Configuration.DocumentElement.SelectNodes(configurationParameter.Name);

                for (int i = 0; i < xNodes.Count; i++)
                {
                    var message = new ValidationResultMessage
                    {
                        Body = configurationParameter.Name
                    };
                    if (new FileInfo(Path.Combine(_package.PackageDirectoryInfo.FullName, xNodes[i].InnerText))
                        .Exists)
                    {
                        message.Status = StatusWords.OK;
                    }
                    else
                    {
                        message.Status = configurationParameter.IsRequired ? StatusWords.ERR : StatusWords.WARN;
                    }
                    messages.Add(message);

                    foreach (var attribute in configurationParameter.Attributes)
                    {
                        messages.AddRange(ValidatorFactory.GetValidator(attribute.ValidationMode, _package).Validate(attribute,i));
                    }

                    foreach (var nestedParameters in configurationParameter.NestedParameters)
                    {
                        messages.AddRange(ValidatorFactory.GetValidator(nestedParameters.ValidationMode, _package).Validate(nestedParameters));
                    }
                }
            }
            else
            {
                messages.Add(new ValidationResultMessage
                {
                    Body = "Configuration file is empty",
                    Status = StatusWords.CRITICAL
                });
            }

            return messages;
        }

        public override IEnumerable<ValidationResultMessage> Validate(ConfigurationParameterAttribute configurationParameterAttribute, int indexOfParentInGroup = 0)
        {
            var messages = base.Validate(configurationParameterAttribute, indexOfParentInGroup).ToList();

            if (messages.All(m => m.Status == StatusWords.OK))
            {
                messages.Clear();

                var parameter = _package.Configuration.DocumentElement.SelectNodes(configurationParameterAttribute.ParameterName)[indexOfParentInGroup];
                var attrValue = parameter.Attributes[configurationParameterAttribute.Name]?.Value;

                var message = new ValidationResultMessage
                {
                    Body = configurationParameterAttribute.ParameterName + " " + configurationParameterAttribute.Name + " \"" + attrValue + "\"",
                    Offset = "    "
                };

                if (new FileInfo(Path.Combine(_package.PackageDirectoryInfo.FullName, attrValue)).Exists)
                {
                    message.Status = StatusWords.OK;
                }
                else
                {
                    message.Status = configurationParameterAttribute.IsRequired ? StatusWords.ERR : StatusWords.WARN;
                }

                messages.Add(message);
            }

            return messages;
        }
    }
}