using SoftwareDesign_lab1.Entities;
using System.Collections.Generic;

namespace SoftwareDesign_lab1.Parsers
{
    class Pcms1Parser : Parser
    {
        public Pcms1Parser(Package package)
        {
            Package = package;

            ConfigurationParameters = new List<ConfigurationParameter>
            {
                new ConfigurationParameter
                {
                    Name = "names",
                    IsRequired = true,
                    ValidationMode=Enums.CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "names/name",
                            IsRequired = true,
                            ValidationMode=Enums.CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "names/name",
                                    Name = "language",
                                    IsRequired = true,
                                    ValidationMode=Enums.CheckMode.ValueIsNotEmptyString
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "names/name",
                                    Name = "value",
                                    IsRequired = true,
                                    ValidationMode=Enums.CheckMode.ValueIsNotEmptyString

                                },
                            }
                        },
                    }
                },
                new ConfigurationParameter
                {
                    Name = "statements",
                    IsRequired = true,
                    ValidationMode=Enums.CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "statements/statement",
                            IsRequired = true,
                            ValidationMode = Enums.CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "statements/statement",
                                    Name = "charset",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "statements/statement",
                                    Name = "language",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "statements/statement",
                                    Name = "path",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "statements/statement",
                                    Name = "type",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"application/x-tex","application/pdf","text/html"},
                                },
                            }
                        }
                    }

                },
                new ConfigurationParameter
                {
                    Name = "tutorials",
                    IsRequired = true,
                    ValidationMode=Enums.CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "tutorials/tutorial",
                            IsRequired = true,
                            ValidationMode=Enums.CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "tutorials/tutorial",
                                    Name = "charset",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "tutorials/tutorial",
                                    Name = "language",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "tutorials/tutorial",
                                    Name = "path",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "tutorials/tutorial",
                                    Name = "type",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.ValueIsInCollection,
                                    AuxiliaryValues = new object[]{"application/x-tex","application/pdf","text/html"},
                                },
                            }
                        },
                    }
                },
                new ConfigurationParameter
                {
                    Name = "judging",
                    IsRequired = true,
                    ValidationMode=Enums.CheckMode.Existing,
                    Attributes = new List<ConfigurationParameterAttribute>
                    {
                        new ConfigurationParameterAttribute
                        {
                            ParameterName = "judging",
                            Name = "cpu-name",
                            IsRequired = true,
                            ValidationMode = Enums.CheckMode.ValueIsNotEmptyString ,
                        },
                         new ConfigurationParameterAttribute
                        {
                            ParameterName = "judging",
                            Name = "cpu-speed",
                            IsRequired = true,
                            ValidationMode = Enums.CheckMode.ValueIsNumber ,
                        },
                          new ConfigurationParameterAttribute
                        {
                            ParameterName = "judging",
                            Name = "input-file",
                            IsRequired = false,
                            ValidationMode = Enums.CheckMode.FileExisting ,
                        },
                           new ConfigurationParameterAttribute
                        {
                            ParameterName = "judging",
                            Name = "output-file",
                            IsRequired = false,
                            ValidationMode = Enums.CheckMode.FileExisting ,
                        },
                    },
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "judging/testset",
                            IsRequired = true,
                            ValidationMode=Enums.CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "judging/testset",
                                    Name = "name",
                                    IsRequired = false,
                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                }
                            },
                            NestedParameters = new List<ConfigurationParameter>
                            {
                                new ConfigurationParameter
                                {
                                    Name = "judging/testset/time-limit",
                                    IsRequired =true,
                                    ValidationMode = Enums.CheckMode.ValueIsNumber ,
                                },
                                new ConfigurationParameter
                                {
                                    Name = "judging/testset/memory-limit",
                                    IsRequired =true,
                                    ValidationMode = Enums.CheckMode.ValueIsNumber ,
                                },
                                new ConfigurationParameter
                                {
                                    Name = "judging/testset/test-count",
                                    IsRequired =true,
                                    ValidationMode = Enums.CheckMode.ValueIsNumber ,
                                },
                                new ConfigurationParameter
                                {
                                    Name = "judging/testset/input-path-pattern",
                                    IsRequired =true,
                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameter
                                {
                                    Name = "judging/testset/answer-path-pattern",
                                    IsRequired =true,
                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameter
                                {
                                    Name = "judging/testset/tests",
                                    IsRequired =true,
                                    ValidationMode = Enums.CheckMode.Existing ,
                                    NestedParameters = new List<ConfigurationParameter>
                                    {
                                        new ConfigurationParameter
                                        {
                                            Name = "judging/testset/tests/test",
                                            IsRequired = true,
                                            ValidationMode = Enums.CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/testset/tests/test",
                                                    Name = "group",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.ValueIsNumber ,
                                                },
                                                 new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/testset/tests/test",
                                                    Name = "method",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.ValueIsInCollection,
                                                    AuxiliaryValues = new object[]{"manual", "generated" }
                                                },
                                                  new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/testset/tests/test",
                                                    Name = "sample",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.ValueIsInCollection ,
                                                    AuxiliaryValues = new object[]{"true","false"}
                                                },
                                                   new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/testset/tests/test",
                                                    Name = "from-file",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString ,
                                                },
                                                    new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "judging/testset/tests/test",
                                                    Name = "cmd",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString ,
                                                },
                                            }
                                        }
                                    }
                                },
                            }
                        },
                    }
                },
                //new ConfigurationParameter
                //{
                //    Name = "",
                //    IsRequired = true,
                //    ValidationMode=Enums.CheckMode.Existing,

                //},
                //next...
            };
        }
    }
}
