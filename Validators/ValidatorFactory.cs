using SoftwareDesign_lab1.Entities;

namespace SoftwareDesign_lab1.Validators
{
    public static class ValidatorFactory
    {
        public static Validator GetValidator(CheckMode checkMode, Package package)
        {
            if(checkMode == CheckMode.Existing) return new ExistenceValidator(package);
            if(checkMode == CheckMode.FileExisting) return new FileExistenceValidator(package);
            return null;
        } 
    }
}
