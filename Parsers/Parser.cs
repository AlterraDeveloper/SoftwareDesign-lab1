using System.Collections.Generic;
using SoftwareDesign_lab1.Entities;

namespace SoftwareDesign_lab1.Parsers
{
    public abstract class Parser
    {
        protected List<ConfigurationParameter> ConfigurationParameters;
        public abstract List<ValidationResultMessage> Parse();
        public abstract void ShowResult(List<ValidationResultMessage> messages);
    }
}