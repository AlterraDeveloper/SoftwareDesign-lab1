using SoftwareDesign_lab1.Entities;
using System.Collections.Generic;
using SoftwareDesign_lab1.Enums;

namespace SoftwareDesign_lab1.Parsers
{
    public class KrsuParser : Parser
    {
        public KrsuParser(Package package)
        {
            Package = package;

            ConfigurationParameters = new List<ConfigurationParameter>
            {
                new ConfigurationParameter
                {
                    Name = "checker",
                    IsRequired = true,
                    ValidationMode = CheckMode.FileExisting
                },
                new ConfigurationParameter
                {
                    Name = "interactor",
                    IsRequired = false,
                    ValidationMode = CheckMode.FileExisting
                },
                new ConfigurationParameter
                {
                    Name = "problem",
                    IsRequired = false,
                    ValidationMode = CheckMode.FileExisting
                },
                new ConfigurationParameter
                {
                    Name = "memorylimit",
                    IsRequired = true,
                    ValidationMode = CheckMode.ValueIsNumber
                },
                new ConfigurationParameter
                {
                    Name = "timelimit",
                    IsRequired = true,
                    ValidationMode = CheckMode.ValueIsNumber
                },
                new ConfigurationParameter
                {
                    Name = "testversion",
                    IsRequired = true,
                    ValidationMode = CheckMode.ValueIsNumber
                },
                new ConfigurationParameter
                {
                    Name = "runtype",
                    IsRequired = true,
                    ValidationMode = CheckMode.ValueIsInRange,
                    AuxiliaryValues = new object[]{0,2}
                },
                new ConfigurationParameter
                {
                    Name = "groups",
                    IsRequired = false,
                    ValidationMode = CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "groups/group",
                            IsRequired = false,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    Name = "id",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                    ParameterName = "groups/group"
                                },
                                new ConfigurationParameterAttribute
                                {
                                    Name = "points",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                    ParameterName = "groups/group"
                                },
                                new ConfigurationParameterAttribute
                                {
                                    Name = "prereq",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                    ParameterName = "groups/group"
                                },
                            }
                        }
                    }
                },
                new ConfigurationParameter
                {
                    Name = "test",
                    IsRequired = true,
                    ValidationMode = CheckMode.Existing,
                    Attributes = new List<ConfigurationParameterAttribute>
                    {
                        new ConfigurationParameterAttribute
                        {
                            Name = "input",
                            IsRequired = true,
                            Attributes = null,
                            ValidationMode = CheckMode.FileExisting,
                            ParameterName = "test"
                        },
                        new ConfigurationParameterAttribute
                        {
                            Name = "output",
                            IsRequired = true,
                            Attributes = null,
                            ValidationMode = CheckMode.FileExisting,
                            ParameterName = "test"
                        },
                        new ConfigurationParameterAttribute
                        {
                            Name = "groupid",
                            IsRequired = false,
                            Attributes = null,
                            ValidationMode = CheckMode.ValueIsNumber,
                            ParameterName = "test"
                        },
                        new ConfigurationParameterAttribute
                        {
                            Name = "points",
                            IsRequired = false,
                            Attributes = null,
                            ValidationMode = CheckMode.ValueIsNumber,
                            ParameterName = "test"
                        },
                    }
                },
            };
        }
    }
}