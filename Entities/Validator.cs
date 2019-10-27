namespace SoftwareDesign_lab1.Entities
{
    public abstract class Validator
    {
        public abstract ValidationResultMessage Validate(ConfigurationParameter configurationParameter);
    }
}