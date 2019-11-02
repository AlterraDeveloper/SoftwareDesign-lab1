using System.Linq;
using SoftwareDesign_lab1.Entities;
using SoftwareDesign_lab1.Enums;

namespace SoftwareDesign_lab1.Validators
{
    public static class ValidatorFactory
    {
        public static Validator GetValidator(CheckMode checkMode, Package package, params object[] auxParams)
        {
            if (checkMode == CheckMode.Existing) return new ExistenceValidator(package);
            if (checkMode == CheckMode.FileExisting) return new FileExistenceValidator(package);
            if (checkMode == CheckMode.ValueIsNumber) return new NumberValidator(package);
            if (checkMode == CheckMode.ValueIsNotEmptyString) return new StringValidator(package);
            if (checkMode == CheckMode.ValueIsInRange)
            {
                var bounds = auxParams.Cast<int>().ToArray();
                return new RangeValidator(package, bounds[0], bounds[1]);
            }

            if (checkMode == CheckMode.ValueIsInCollection)
            {
                return new CollectionValidator(package, auxParams.Cast<string>().ToArray());
            }

            if (checkMode == CheckMode.FileRangeExisting)
            {
                return new FileRangeValidator(package,(string) auxParams[0]);
            }
            return null;
        }
    }
}
