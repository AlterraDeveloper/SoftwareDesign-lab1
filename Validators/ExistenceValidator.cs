using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
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

        public override IEnumerable<ValidationResultMessage> Validate(ConfigurationParameter configurationParameter)
        {
            var messages = new List<ValidationResultMessage>();

            if (_package.Configuration.DocumentElement != null)
            {
                if (configurationParameter is ConfigurationParameterAttribute)
                {
                    var attribute = (ConfigurationParameterAttribute) configurationParameter;

                    var attrValue = _package.Configuration.DocumentElement.SelectSingleNode(attribute.ParameterName).Attributes[attribute.Name]?.Value;

                    var message = new ValidationResultMessage
                    {
                        Body = attribute.ParameterName + " " + attribute.Name + " " + attrValue,
                        Offset = "    "
                    };

                    if (string.IsNullOrEmpty(attrValue))
                    {
                        message.Status = attribute.IsRequired ? StatusWords.ERR : StatusWords.WARN;
                    }
                    else
                    {
                        message.Status = StatusWords.OK;
                    }

                    messages.Add(message);
                }
                else
                {
                    var xNodes = _package.Configuration.DocumentElement.SelectNodes(configurationParameter.Name);

                    if (xNodes.Count == 0)
                    {
                        var message = new ValidationResultMessage
                        {
                            Body = configurationParameter.Name,
                            Status = configurationParameter.IsRequired ? StatusWords.ERR : StatusWords.WARN
                        };
                        messages.Add(message);
                    }
                    else
                    {
                        foreach (XmlNode node in xNodes)
                        {
                            messages.Add(new ValidationResultMessage
                            {
                                Body = configurationParameter.Name,
                                Status = StatusWords.OK
                            });
                        }
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