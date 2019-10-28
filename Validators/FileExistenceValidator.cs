using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using SoftwareDesign_lab1.Enums;

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
                if (configurationParameter is ConfigurationParameterAttribute)
                {
                    var attribute = (ConfigurationParameterAttribute)configurationParameter;

                    var attrValue = _package.Configuration.DocumentElement.SelectSingleNode(attribute.ParameterName).Attributes[attribute.Name]?.Value;

                    var message = new ValidationResultMessage
                    {
                        Body = attribute.ParameterName + " " + attribute.Name + " " + attrValue,
                        Offset = "    "
                    };

                    if (new FileInfo(Path.Combine(_package.PackageDirectoryInfo.FullName,attrValue)).Exists)
                    {
                        message.Status = StatusWords.OK;
                    }
                    else
                    {
                        message.Status = attribute.IsRequired ? StatusWords.ERR : StatusWords.WARN;
                    }

                    messages.Add(message);
                }
                else
                {
                    var xNodes = _package.Configuration.DocumentElement.SelectNodes(configurationParameter.Name);

                    foreach (XmlNode node in xNodes)
                    {
                        var message = new ValidationResultMessage
                        {
                            Body = configurationParameter.Name
                        };
                        if (new FileInfo(Path.Combine(_package.PackageDirectoryInfo.FullName, node.InnerText))
                            .Exists)
                        {
                            message.Status = StatusWords.OK;
                        }
                        else
                        {
                            message.Status = configurationParameter.IsRequired ? StatusWords.ERR : StatusWords.WARN;
                        }
                        messages.Add(message);
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
    }
}