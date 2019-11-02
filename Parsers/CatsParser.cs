using SoftwareDesign_lab1.Entities;
using System.Collections.Generic;
using SoftwareDesign_lab1.Enums;

namespace SoftwareDesign_lab1.Parsers
{
    public class CatsParser : Parser
    {
        public CatsParser(Package package)
        {
            Package = package;

            ConfigurationParameters = new List<ConfigurationParameter>
            {
                new ConfigurationParameter
                {
                    Name = "Problem",
                    IsRequired = true,
                    ValidationMode = CheckMode.Existing,
                    Attributes = new List<ConfigurationParameterAttribute>
                    {
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "title",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "lang",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "tlimit",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNumber,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "mlimit",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNumber,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "wlimit",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNumber,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "author",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "inputFile",
                            IsRequired = true,
                            ValidationMode = CheckMode.FileExisting,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "outputFile",
                            IsRequired = true,
                            ValidationMode = CheckMode.FileExisting,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "difficulty",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsInRange,
                            AuxiliaryValues = new object[]{1,100},
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "stdChecker",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsInCollection,
                            AuxiliaryValues = new object[]{"nums","floats2","strs","longnums","longstrs"}
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "maxPoints",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNumber,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "saveInputPrefix",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNumber,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "saveOutputPrefix",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNumber,
                        },
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "Problem",
                            Name = "saveAnswerPrefix",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNumber,
                        },
                    },
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "Problem/Keyword",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Keyword",
                                    Name = "code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                }
                            },
                        },
                        new ConfigurationParameter
                        {
                           Name = "Problem/ProblemStatement",
                           IsRequired = false,
                           ValidationMode = CheckMode.ValueIsNotEmptyString,
                           Attributes = new List<ConfigurationParameterAttribute>
                           {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/ProblemStatement",
                                    Name = "attachment",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/ProblemStatement",
                                    Name = "url",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString
                                },
                           }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/ProblemConstraints",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/InputFormat",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/OutputFormat",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/JsonData",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Explanation",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Explanation",
                                    Name = "attachment",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Explanation",
                                    Name = "url",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString
                                },
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Checker",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Checker",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Checker",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Checker",
                                    Name = "de_code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"1", "2", "101", "102", "103", "104", "105", "201", "202", "203", "301", "302", "401", "402", "501", "502", "503", "504", },
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Checker",
                                    Name = "style",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"legacy", "testlib", "partial", "multiple"},
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Checker",
                                    Name = "export",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Checker",
                                    Name = "timeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Checker",
                                    Name = "memoryLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Checker",
                                    Name = "writeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Picture",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Picture",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Picture",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Attachment",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Attachment",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Attachment",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Solution",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Solution",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Solution",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Solution",
                                    Name = "de_code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"1", "2", "101", "102", "103", "104", "105", "201", "202", "203", "301", "302", "401", "402", "501", "502", "503", "504", },
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Solution",
                                    Name = "export",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Solution",
                                    Name = "timeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Solution",
                                    Name = "memoryLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Solution",
                                    Name = "writeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                            },
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Generator",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Generator",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Generator",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Generator",
                                    Name = "de_code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"1", "2", "101", "102", "103", "104", "105", "201", "202", "203", "301", "302", "401", "402", "501", "502", "503", "504", },
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Generator",
                                    Name = "outputFile",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Generator",
                                    Name = "export",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Generator",
                                    Name = "timeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Generator",
                                    Name = "memoryLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Generator",
                                    Name = "writeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                            },
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/GeneratorRange",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "from",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "to",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "de_code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"1", "2", "101", "102", "103", "104", "105", "201", "202", "203", "301", "302", "401", "402", "501", "502", "503", "504", },
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "outputFile",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "export",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "timeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "memoryLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/GeneratorRange",
                                    Name = "writeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                            },
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Validator",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Validator",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Validator",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Validator",
                                    Name = "de_code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"1", "2", "101", "102", "103", "104", "105", "201", "202", "203", "301", "302", "401", "402", "501", "502", "503", "504", },
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Validator",
                                    Name = "export",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Validator",
                                    Name = "timeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Validator",
                                    Name = "memoryLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Validator",
                                    Name = "writeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                            },
                        },
                         new ConfigurationParameter
                        {
                            Name = "Problem/Visualizer",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Visualizer",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Visualizer",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Visualizer",
                                    Name = "de_code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"1", "2", "101", "102", "103", "104", "105", "201", "202", "203", "301", "302", "401", "402", "501", "502", "503", "504", },
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Visualizer",
                                    Name = "export",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                            },
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Interactor",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Interactor",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Interactor",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Interactor",
                                    Name = "de_code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"1", "2", "101", "102", "103", "104", "105", "201", "202", "203", "301", "302", "401", "402", "501", "502", "503", "504", },
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Interactor",
                                    Name = "export",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Interactor",
                                    Name = "timeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Interactor",
                                    Name = "memoryLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Interactor",
                                    Name = "writeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                            },
                        },
                         new ConfigurationParameter
                        {
                            Name = "Problem/Linter",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Linter",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Linter",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Linter",
                                    Name = "stage",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"before","after"},
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Linter",
                                    Name = "de_code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"1", "2", "101", "102", "103", "104", "105", "201", "202", "203", "301", "302", "401", "402", "501", "502", "503", "504", },
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Linter",
                                    Name = "export",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Linter",
                                    Name = "timeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Linter",
                                    Name = "memoryLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Linter",
                                    Name = "writeLimit",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                            },
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Run",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Run",
                                    Name = "method",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"default","interactive","competitive"},
                                }
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Test",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test",
                                    Name = "rank",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test",
                                    Name = "points",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                }
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Test/In",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test/In",
                                    Name = "use",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test/In",
                                    Name = "param",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test/In",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileRangeExisting,
                                    AuxiliaryValues = new object[]{ "Problem/TestRange" }
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test/In",
                                    Name = "genAll",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.Existing,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test/In",
                                    Name = "validate",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test/In",
                                    Name = "hash",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Test/Out",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test/Out",
                                    Name = "use",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Test/Out",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting
                                }
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/TestRange",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange",
                                    Name = "from",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange",
                                    Name = "to",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange",
                                    Name = "points",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                }
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/TestRange/In",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                               new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange/In",
                                    Name = "use",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange/In",
                                    Name = "param",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange/In",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileRangeExisting,
                                    AuxiliaryValues = new object[]{ "Problem/TestRange" }
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange/In",
                                    Name = "genAll",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.Existing,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange/In",
                                    Name = "validate",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange/In",
                                    Name = "hash",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/TestRange/Out",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange/Out",
                                    Name = "use",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/TestRange/Out",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting
                                }
                            }
                        },
                         new ConfigurationParameter
                        {
                            Name = "Problem/Testset",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                               new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Testset",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Testset",
                                    Name = "tests",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Testset",
                                    Name = "points",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Testset",
                                    Name = "hideDetails",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.Existing,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Testset",
                                    Name = "comment",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Testset",
                                    Name = "depends_on",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Module",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                               new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Module",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Module",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Module",
                                    Name = "de_code",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"1", "2", "101", "102", "103", "104", "105", "201", "202", "203", "301", "302", "401", "402", "501", "502", "503", "504", },
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Module",
                                    Name = "type",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"generator","checker","solution"}
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Module",
                                    Name = "export",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Module",
                                    Name = "main",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                            }
                        },
                         new ConfigurationParameter
                        {
                            Name = "Problem/Import",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                               new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Import",
                                    Name = "guid",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Import",
                                    Name = "type",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"generator","checker","solution"}
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Import",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Sample",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Sample",
                                    Name = "rank",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNumber
                                }
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Sample/SampleIn",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Sample/SampleIn",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting
                                }
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "Problem/Sample/SampleOut",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "Problem/Sample/SampleOut",
                                    Name = "src",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting
                                }
                            }
                        },
                        //next...
                    }
                },

            };
        }
    }
}
