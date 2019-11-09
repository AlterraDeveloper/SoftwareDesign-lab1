using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SoftwareDesign_lab1.Entities;
using SoftwareDesign_lab1.Enums;

namespace SoftwareDesign_lab1.Parsers
{
    public class Pcms2Parser : Parser
    {
        public Pcms2Parser(Package package)
        {
            Package = package;

            ConfigurationParameters = new List<ConfigurationParameter>
            {
                new ConfigurationParameter
                {
                    Name = "judging",
                    IsRequired = true,
                    ValidationMode = CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "judging/script",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "judging/script",
                                    Name = "type",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                }
                            },
                            NestedParameters = new List<ConfigurationParameter>
                            {
                                new ConfigurationParameter
                                {
                                    Name = "judging/script/testset",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.Existing,
                                    Attributes = new List<ConfigurationParameterAttribute>
                                    {
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "judging/script/testset",
                                            Name = "name",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "judging/script/testset",
                                            Name = "input-name",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.FileExisting,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "judging/script/testset",
                                            Name = "output-name",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.FileExisting,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "judging/script/testset",
                                            Name = "input-href",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "judging/script/testset",
                                            Name = "answer-href",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "judging/script/testset",
                                            Name = "time-limit",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "judging/script/testset",
                                            Name = "memory-limit",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.ValueIsNumber,
                                        },
                                    },
                                    NestedParameters = new List<ConfigurationParameter>
                                    {
                                        new ConfigurationParameter
                                        {
                                            Name = "judging/script/testset/test",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/testset/test",
                                                    Name = "points",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.ValueIsNumber,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/testset/test",
                                                    Name = "comment",
                                                    IsRequired = false,
                                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                },
                                            }
                                        },
                                        new ConfigurationParameter
                                        {
                                            Name = "judging/script/testset/test-group",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/testset/test-group",
                                                    Name = "comment",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/testset/test-group",
                                                    Name = "score",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/testset/test-group",
                                                    Name = "feedback",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/testset/test-group",
                                                    Name = "group-bonus",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.ValueIsNumber,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/testset/test-group",
                                                    Name = "require-previous",
                                                    IsRequired = false,
                                                    ValidationMode = CheckMode.ValueIsInCollection,
                                                    AuxiliaryValues = new object[]{"true","false"}
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/testset/test-group",
                                                    Name = "require-groups",
                                                    IsRequired = false,
                                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                },
                                            },
                                            NestedParameters = new List<ConfigurationParameter>
                                            {
                                                new ConfigurationParameter
                                                {
                                                    Name = "judging/script/testset/test-group/test",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.Existing,
                                                    Attributes = new List<ConfigurationParameterAttribute>
                                                    {
                                                        new ConfigurationParameterAttribute
                                                        {
                                                            ParameterName = "judging/script/testset/test-group/test",
                                                            Name = "points",
                                                            IsRequired = true,
                                                            ValidationMode = CheckMode.ValueIsNumber,
                                                        },
                                                        new ConfigurationParameterAttribute
                                                        {
                                                            ParameterName = "judging/script/testset/test-group/test",
                                                            Name = "comment",
                                                            IsRequired = false,
                                                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                        },
                                                    }
                                                },
                                            }
                                        }
                                    }
                                },
                                new ConfigurationParameter
                                {
                                    Name = "judging/script/verifier",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.Existing,
                                    Attributes = new List<ConfigurationParameterAttribute>
                                    {
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "judging/script/verifier",
                                            Name = "type",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.ValueIsNotEmptyString
                                        }
                                    },
                                    NestedParameters = new List<ConfigurationParameter>
                                    {
                                        new ConfigurationParameter
                                        {
                                            Name = "judging/script/verifier/binary",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/verifier/binary",
                                                    Name = "executable-id",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/verifier/binary",
                                                    Name = "file",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.FileExisting,
                                                },
                                            }
                                        }
                                    }
                                },
                                new ConfigurationParameter
                                {
                                    Name = "judging/script/interactor",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.Existing,
                                    Attributes = new List<ConfigurationParameterAttribute>
                                    {
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "judging/script/interactor",
                                            Name = "type",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.ValueIsNotEmptyString
                                        }
                                    },
                                    NestedParameters = new List<ConfigurationParameter>
                                    {
                                        new ConfigurationParameter
                                        {
                                            Name = "judging/script/interactor/binary",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/interactor/binary",
                                                    Name = "executable-id",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/script/interactor/binary",
                                                    Name = "file",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.FileExisting,
                                                },
                                            }
                                        }
                                    }
                                },
                            }
                        }
                    }
                }
            };
        }
    }
}
