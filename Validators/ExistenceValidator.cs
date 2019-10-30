using SoftwareDesign_lab1.Enums;
using System.Collections.Generic;
using System.Xml;
using System;
using SoftwareDesign_lab1.Validators;

namespace SoftwareDesign_lab1.Entities
{
    public class ExistenceValidator : Validator
    {
        public ExistenceValidator(Package package)
        {
            _package = package;
        }

        public override IEnumerable<ValidationResultMessage> Validate(ConfigurationParameter configurationParameter)
        {
            var messages = new List<ValidationResultMessage>();

            if (_package.Configuration.DocumentElement != null)
            {
                var xNodes = GetConfigurationParameters(configurationParameter);

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
                    for (int i = 0; i < xNodes.Count; i++)
                    {
                        messages.Add(new ValidationResultMessage
                        {
                            Body = configurationParameter.Name,
                            Status = StatusWords.OK
                        });

                        foreach (var attribute in configurationParameter.Attributes)
                        {
                            messages.AddRange(ValidatorFactory.GetValidator(attribute.ValidationMode, _package).Validate(attribute,i));
                        }
                        foreach (var parameter in configurationParameter.NestedParameters)
                        {
                            messages.AddRange(ValidatorFactory.GetValidator(parameter.ValidationMode, _package).Validate(parameter));
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

        public override IEnumerable<ValidationResultMessage> Validate(ConfigurationParameterAttribute configurationParameterAttribute, int indexOfParentInGroup = 0)
        {
            var messages = new List<ValidationResultMessage>();

            var attrValue =
                GetConfigurationParamenterAttributeValue(configurationParameterAttribute, indexOfParentInGroup);

            var message = new ValidationResultMessage
            {
                Body = configurationParameterAttribute.ParameterName + " " + configurationParameterAttribute.Name + " = \"" + attrValue + "\"",
                Offset = "    "
            };

            if (string.IsNullOrEmpty(attrValue) ==false)
            {
                message.Status = StatusWords.OK;
            }
            else
            {
                message.Status = configurationParameterAttribute.IsRequired ? StatusWords.ERR : StatusWords.WARN;
            }

            messages.Add(message);

            return messages;
        }
    }
}