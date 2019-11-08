using SoftwareDesign_lab1.Entities;
using System.Collections.Generic;
using SoftwareDesign_lab1.Enums;

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
                new ConfigurationParameter
                {
                    Name = "files",
                    IsRequired = true,
                    ValidationMode=Enums.CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "files/resources",
                            IsRequired = true,
                            ValidationMode = Enums.CheckMode.Existing,
                            NestedParameters = new List<ConfigurationParameter>
                            {
                                new ConfigurationParameter
                                {
                                    Name = "files/resources/file",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.Existing,
                                    Attributes = new List<ConfigurationParameterAttribute>
                                    {
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "files/resources/file",
                                            Name = "path",
                                            IsRequired = true,
                                            ValidationMode = Enums.CheckMode.FileExisting,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "files/resources/file",
                                            Name = "type",
                                            IsRequired = false,
                                            ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                        }
                                    }
                                }
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "files/executables",
                            IsRequired = true,
                            ValidationMode = Enums.CheckMode.Existing,
                            NestedParameters = new List<ConfigurationParameter>
                            {
                                new ConfigurationParameter
                                {
                                    Name = "files/executables/executable",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.Existing,
                                    NestedParameters = new List<ConfigurationParameter>
                                    {
                                        new ConfigurationParameter
                                        {
                                            Name = "files/executables/executable/source",
                                            IsRequired =true,
                                            ValidationMode = Enums.CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                 new ConfigurationParameterAttribute
                                                 {
                                                    ParameterName = "files/executables/executable/source",
                                                    Name = "path",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.FileExisting,
                                                 },
                                                 new ConfigurationParameterAttribute
                                                 {
                                                    ParameterName = "files/executables/executable/source",
                                                    Name = "type",
                                                    IsRequired = false,
                                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                                 },
                                            }
                                        },
                                         new ConfigurationParameter
                                        {
                                            Name = "files/executables/executable/binary",
                                            IsRequired =true,
                                            ValidationMode = Enums.CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                 new ConfigurationParameterAttribute
                                                 {
                                                    ParameterName = "files/executables/executable/binary",
                                                    Name = "path",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.FileExisting,
                                                 },
                                                 new ConfigurationParameterAttribute
                                                 {
                                                    ParameterName = "files/executables/executable/binary",
                                                    Name = "type",
                                                    IsRequired = false,
                                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                                 },
                                            }
                                        },
                                    },
                                    Attributes = new List<ConfigurationParameterAttribute>
                                    {
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "files/executables/executable",
                                            Name = "path",
                                            IsRequired = true,
                                            ValidationMode = Enums.CheckMode.FileExisting,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "files/executables/executable",
                                            Name = "type",
                                            IsRequired = false,
                                            ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                        }
                                    },
                                }
                            }
                        }
                    }
                },
                new ConfigurationParameter
                {
                    Name = "assets",
                    IsRequired = true,
                    ValidationMode = Enums.CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "assets/checker",
                            IsRequired = true,
                            ValidationMode = Enums.CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "assets/checker",
                                    Name = "name",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "assets/checker",
                                    Name = "type",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                },
                            },
                            NestedParameters = new List<ConfigurationParameter>
                            {
                                new ConfigurationParameter
                                {
                                    Name = "assets/checker/source",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.Existing,
                                    Attributes = new List<ConfigurationParameterAttribute>
                                    {
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "assets/checker/source",
                                            Name = "path",
                                            IsRequired = true,
                                            ValidationMode = Enums.CheckMode.FileExisting,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "assets/checker/source",
                                            Name = "type",
                                            IsRequired = false,
                                            ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                        }
                                    },
                                },
                                 new ConfigurationParameter
                                 {
                                    Name = "assets/checker/binary",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.Existing,
                                    Attributes = new List<ConfigurationParameterAttribute>
                                    {
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "assets/checker/binary",
                                            Name = "path",
                                            IsRequired = true,
                                            ValidationMode = Enums.CheckMode.FileExisting,
                                        },
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "assets/checker/binary",
                                            Name = "type",
                                            IsRequired = false,
                                            ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                        }
                                    },
                                 },
                                  new ConfigurationParameter
                                  {
                                    Name = "assets/checker/copy",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.Existing,
                                    Attributes = new List<ConfigurationParameterAttribute>
                                    {
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "assets/checker/copy",
                                            Name = "path",
                                            IsRequired = true,
                                            ValidationMode = Enums.CheckMode.FileExisting,
                                        },
                                    },
                                  },
                                  new ConfigurationParameter
                                  {
                                      Name = "assets/checker/testset",
                                      IsRequired = true,
                                      ValidationMode = Enums.CheckMode.Existing,
                                      NestedParameters = new List<ConfigurationParameter>
                                      {
                                          new ConfigurationParameter
                                          {
                                               Name = "assets/checker/testset/test-count",
                                               IsRequired = true,
                                               ValidationMode = Enums.CheckMode.ValueIsNumber,
                                          },
                                          new ConfigurationParameter
                                          {
                                               Name = "assets/checker/testset/input-path-pattern",
                                               IsRequired = true,
                                               ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                          },
                                          new ConfigurationParameter
                                          {
                                               Name = "assets/checker/testset/output-path-pattern",
                                               IsRequired = true,
                                               ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                          },
                                          new ConfigurationParameter
                                          {
                                               Name = "assets/checker/testset/answer-path-pattern",
                                               IsRequired = true,
                                               ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                          },
                                          new ConfigurationParameter
                                          {
                                               Name = "assets/checker/testset/tests",
                                               IsRequired = false,
                                               ValidationMode = Enums.CheckMode.Existing,
                                          },
                                      }
                                  }
                            },
                        },
                        new ConfigurationParameter
                        {
                            Name = "assets/validators",
                            IsRequired = true,
                            ValidationMode = Enums.CheckMode.Existing,
                            NestedParameters = new List<ConfigurationParameter>
                            {
                                new ConfigurationParameter
                                {
                                    Name = "assets/validators/validator",
                                    IsRequired = true,
                                    ValidationMode = Enums.CheckMode.Existing,
                                    NestedParameters = new List<ConfigurationParameter>
                                    {
                                        new ConfigurationParameter
                                        {
                                            Name = "assets/validators/validator/source",
                                            IsRequired =true,
                                            ValidationMode = Enums.CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "assets/validators/validator/source",
                                                    Name = "path",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.FileExisting,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "assets/validators/validator/source",
                                                    Name = "type",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                                },
                                            }
                                        },
                                        new ConfigurationParameter
                                        {
                                            Name = "assets/validators/validator/binary",
                                            IsRequired =true,
                                            ValidationMode = Enums.CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "assets/validators/validator/binary",
                                                    Name = "path",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.FileExisting,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "assets/validators/validator/binary",
                                                    Name = "type",
                                                    IsRequired = true,
                                                    ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                                },
                                            }
                                        },
                                        new ConfigurationParameter
                                        {
                                             Name = "assets/validators/validator/testset",
                                             IsRequired = true,
                                             ValidationMode = Enums.CheckMode.Existing,
                                             NestedParameters = new List<ConfigurationParameter>
                                             {
                                                 new ConfigurationParameter
                                                 {
                                                      Name = "assets/validators/validator/testset/test-count",
                                                      IsRequired = true,
                                                      ValidationMode = Enums.CheckMode.ValueIsNumber,
                                                 },
                                                 new ConfigurationParameter
                                                 {
                                                      Name = "assets/validators/validator/testset/input-path-pattern",
                                                      IsRequired = true,
                                                      ValidationMode = Enums.CheckMode.ValueIsNotEmptyString,
                                                 },
                                                 new ConfigurationParameter
                                                 {
                                                      Name = "assets/validators/validator/testset/tests",
                                                      IsRequired = false,
                                                      ValidationMode = Enums.CheckMode.Existing,
                                                      NestedParameters = new List<ConfigurationParameter>
                                                      {
                                                          new ConfigurationParameter
                                                          {
                                                              Name = "assets/validators/validator/testset/tests/test",
                                                              IsRequired =true,
                                                              ValidationMode = Enums.CheckMode.Existing,
                                                              Attributes = new List<ConfigurationParameterAttribute>
                                                              {
                                                                  new ConfigurationParameterAttribute
                                                                  {
                                                                      ParameterName = "assets/validators/validator/testset/tests/test",
                                                                      Name = "verdict",
                                                                      IsRequired = true,
                                                                      ValidationMode = Enums.CheckMode.ValueIsInCollection,
                                                                      AuxiliaryValues = new object[]{"valid","invalid"},
                                                                  }
                                                              }
                                                          }
                                                      }
                                                 },
                                             }
                                        }
                                    }
                                }
                            }
                        },
                        new ConfigurationParameter
                        {
                            Name = "assets/solutions",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            NestedParameters = new List<ConfigurationParameter>
                            {
                                new ConfigurationParameter
                                {
                                    Name = "assets/solutions/solution",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.Existing,
                                    Attributes = new List<ConfigurationParameterAttribute>
                                    {
                                        new ConfigurationParameterAttribute
                                        {
                                            ParameterName = "assets/solutions/solution",
                                            Name = "tag",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.ValueIsNotEmptyString
                                        }
                                    },
                                    NestedParameters = new List<ConfigurationParameter>
                                    {
                                        new ConfigurationParameter
                                        {
                                            Name = "assets/solutions/solution/source",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "assets/solutions/solution/source",
                                                    Name = "path",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.FileExisting,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "assets/solutions/solution/source",
                                                    Name = "type",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                },
                                            }
                                        },
                                        new ConfigurationParameter
                                        {
                                            Name = "assets/solutions/solution/binary",
                                            IsRequired = true,
                                            ValidationMode = CheckMode.Existing,
                                            Attributes = new List<ConfigurationParameterAttribute>
                                            {
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "assets/solutions/solution/binary",
                                                    Name = "path",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.FileExisting,
                                                },
                                                new ConfigurationParameterAttribute
                                                {
                                                    ParameterName = "assets/solutions/solution/binary",
                                                    Name = "type",
                                                    IsRequired = true,
                                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                                },
                                            }
                                        },
                                    }
                                }
                            }
                        }
                    },                    
                },
                new ConfigurationParameter
                {
                    Name = "properties",
                    IsRequired = true,
                    ValidationMode = CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "properties/property",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "properties/property",
                                    Name = "name",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "properties/property",
                                    Name = "value",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                }
                            }
                        }
                    }
                },
                new ConfigurationParameter
                {
                    Name = "stresses",
                    IsRequired = true,
                    ValidationMode = CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "stresses/stress-count",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNumber,
                        },
                        new ConfigurationParameter
                        {
                            Name = "stresses/stress-path-pattern",
                            IsRequired = true,
                            ValidationMode = CheckMode.ValueIsNotEmptyString,
                        },
                        new ConfigurationParameter
                        {
                            Name = "stresses/list",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                        },
                    }
                },
                new ConfigurationParameter
                {
                    Name = "documents",
                    IsRequired = true,
                    ValidationMode = CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "documents/document",
                            IsRequired = true,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "documents/document",
                                    Name = "path",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.FileExisting,
                                },
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "documents/document",
                                    Name = "type",
                                    IsRequired = true,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                },
                            }
                        }
                    }
                },
                new ConfigurationParameter
                {
                    Name = "tags",
                    IsRequired = false,
                    ValidationMode = CheckMode.Existing,
                    NestedParameters = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "tags/tag",
                            IsRequired = false,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    ParameterName = "tags/tag",
                                    Name = "value",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.ValueIsNotEmptyString,
                                }
                            }
                        }
                    }
                },
            };
        }
    }
}
