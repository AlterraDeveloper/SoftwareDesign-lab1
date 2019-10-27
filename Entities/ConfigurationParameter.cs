using System.Collections.Generic;

namespace SoftwareDesign_lab1.Entities
{
    public class ConfigurationParameter
    {
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public List<ConfigurationParameter> Attributes { get; set; }
        public Validator Validator { get; set; }
    }
}