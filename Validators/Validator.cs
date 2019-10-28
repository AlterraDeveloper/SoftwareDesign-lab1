using System.Collections.Generic;

namespace SoftwareDesign_lab1.Entities
{
    public abstract class Validator
    {
        public abstract IEnumerable<ValidationResultMessage> Validate(ConfigurationParameter configurationParameter);
    }
}