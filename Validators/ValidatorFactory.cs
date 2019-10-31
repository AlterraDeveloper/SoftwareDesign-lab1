using SoftwareDesign_lab1.Entities;

namespace SoftwareDesign_lab1.Validators
{
    public static class ValidatorFactory
    {
        public static Validator GetValidator(CheckMode checkMode, Package package,params object[] auxParams)
        {
            if(checkMode == CheckMode.Existing) return new ExistenceValidator(package);
            if(checkMode == CheckMode.FileExisting) return new FileExistenceValidator(package);
            if (checkMode == CheckMode.ValueIsInteger) return new IntegerValidator(package);
            if (checkMode == CheckMode.ValueIsInRange)
            {                
                return new RangeValidator(package,(int)auxParams[0], (int)auxParams[1]); 
            }
            return null;
        } 
    }
}
