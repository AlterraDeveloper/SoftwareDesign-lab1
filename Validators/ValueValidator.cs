using SoftwareDesign_lab1.Entities;
using SoftwareDesign_lab1.Enums;
using System.Collections.Generic;
using System.Linq;

namespace SoftwareDesign_lab1.Validators
{
    public abstract class ValueValidator : Validator
    {
        protected abstract bool CheckValue(string value);

        protected ValueValidator(Package package)
        {
            Package = package;
        }

        public override IEnumerable<ValidationResultMessage> Validate(ConfigurationParameter configurationParameter)
        {
            var messages = GetMessagesFromExistenceValidator(configurationParameter).ToList();

            if (messages.Count != 0) return messages;

            if (Package.Configuration.DocumentElement != null)
            {
                var xNodes = base.GetConfigurationParameters(configurationParameter);

                for (int i = 0; i < xNodes.Count; i++)
                {
                    var message = new ValidationResultMessage
                    {
                        Body = configurationParameter.Name
                    };

                    if (CheckValue(xNodes[i].InnerText))
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
            var messages = GetMessagesFromExistenceValidator(configurationParameterAttribute,indexOfParentInGroup).ToList();

            if (messages.Count != 0) return messages;

            if (Package.Configuration.DocumentElement != null)
            {
                var attrValue =
                    GetConfigurationParamenterAttributeValue(configurationParameterAttribute, indexOfParentInGroup);

                var message = new ValidationResultMessage
                {
                    Body = configurationParameterAttribute.ParameterName + " " + configurationParameterAttribute.Name + " = \"" + attrValue + "\"",
                    Offset = "    "
                };

                if (CheckValue(attrValue))
                {
                    message.Status = StatusWords.OK;
                }
                else
                {
                    message.Status = configurationParameterAttribute.IsRequired ? StatusWords.ERR : StatusWords.WARN;
                }

                messages.Add(message);
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

        private IEnumerable<ValidationResultMessage> GetMessagesFromExistenceValidator(ConfigurationParameter configurationParameter,int index = 0)
        {
            var messages = new List<ValidationResultMessage>();
            var existenceValidator = new ExistenceValidator(Package);

            if (configurationParameter.GetType() == typeof(ConfigurationParameter))
            {
                messages = existenceValidator.Validate(configurationParameter).ToList();
            }
            else if (configurationParameter.GetType() == typeof(ConfigurationParameterAttribute))
            {
                messages = existenceValidator.Validate(configurationParameter as ConfigurationParameterAttribute,index).ToList();
            }

            if (messages.All(m => m.Status == StatusWords.OK))
            {
                messages.Clear();
            }

            return messages;
        }
    }
}
