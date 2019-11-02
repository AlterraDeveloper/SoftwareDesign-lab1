using System.Collections.Generic;
using System.Xml;

namespace SoftwareDesign_lab1.Entities
{
    public abstract class Validator
    {
        public abstract IEnumerable<ValidationResultMessage> Validate(ConfigurationParameter configurationParameter);
        public abstract IEnumerable<ValidationResultMessage> Validate(ConfigurationParameterAttribute configurationParameterAttribute,int indexOfParentInGroup = 0);

        protected Package Package;

        protected XmlNodeList GetConfigurationParameters(ConfigurationParameter configurationParameter)
        {
            return Package.Configuration.DocumentElement.SelectNodes(configurationParameter.Name);
        }

        protected string GetConfigurationParamenterAttributeValue(ConfigurationParameterAttribute configurationParameterAttribute, int index = 0)
        {
            var parameter = Package.Configuration.DocumentElement.SelectNodes(configurationParameterAttribute.ParameterName)[index];
            return parameter.Attributes[configurationParameterAttribute.Name]?.Value;
        }
    }
}