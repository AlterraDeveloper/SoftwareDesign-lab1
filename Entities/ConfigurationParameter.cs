using System.Collections.Generic;
using System.Linq;
using SoftwareDesign_lab1.Enums;
using SoftwareDesign_lab1.Validators;

namespace SoftwareDesign_lab1.Entities
{
    public class ConfigurationParameter
    {
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public CheckMode ValidationMode { get; set; }

        public object[] AuxiliaryValues { get; set; }
        public List<ConfigurationParameter> NestedParameters { get; set; }
        public List<ConfigurationParameterAttribute> Attributes { get; set; }

        public ConfigurationParameter()
        {
            NestedParameters = new List<ConfigurationParameter>();
            Attributes = new List<ConfigurationParameterAttribute>();
            AuxiliaryValues = null;
        }

        public List<ValidationResultMessage> Validate(Package package)
        {
            var messages = new List<ValidationResultMessage>();

            messages.AddRange(ValidatorFactory.GetValidator(ValidationMode, package,AuxiliaryValues).Validate(this));

            if (messages.All(m => m.Status == StatusWords.OK))
            {
                foreach (var attribute in Attributes)
                {
                    messages.AddRange(ValidatorFactory.GetValidator(attribute.ValidationMode, package,attribute.AuxiliaryValues).Validate(attribute));
                }

                foreach (var nestedParameter in NestedParameters)
                {
                    messages.AddRange(ValidatorFactory.GetValidator(nestedParameter.ValidationMode, package,nestedParameter.AuxiliaryValues).Validate(nestedParameter));
                }
            }

            return messages;
        }
    }
}