using SoftwareDesign_lab1.Entities;
using SoftwareDesign_lab1.Enums;
using System;
using System.Collections.Generic;

namespace SoftwareDesign_lab1.Parsers
{
    public class KrsuParser : Parser
    {
        private Package _package;

        public KrsuParser(Package package)
        {
            _package = package;

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
                    ValidationMode = CheckMode.Existing
                },
                new ConfigurationParameter
                {
                    Name = "timelimit",
                    IsRequired = true,
                    ValidationMode = CheckMode.Existing
                },
                new ConfigurationParameter
                {
                    Name = "testversion",
                    IsRequired = true,
                    ValidationMode = CheckMode.Existing
                },
                new ConfigurationParameter
                {
                    Name = "runtype",
                    IsRequired = true,
                    ValidationMode = CheckMode.Existing
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
                            Name = "group",
                            IsRequired = false,
                            ValidationMode = CheckMode.Existing,
                            Attributes = new List<ConfigurationParameterAttribute>
                            {
                                new ConfigurationParameterAttribute
                                {
                                    Name = "id",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.Existing,
                                    ParameterName = "group"
                                },
                                new ConfigurationParameterAttribute
                                {
                                    Name = "points",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.Existing,
                                    ParameterName = "group"
                                },
                                new ConfigurationParameterAttribute
                                {
                                    Name = "prereq",
                                    IsRequired = false,
                                    ValidationMode = CheckMode.Existing,
                                    ParameterName = "group"
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
                            ValidationMode = CheckMode.Existing,
                            ParameterName = "test"
                        },
                        new ConfigurationParameterAttribute
                        {
                            Name = "points",
                            IsRequired = false,
                            Attributes = null,
                            ValidationMode = CheckMode.Existing,
                            ParameterName = "test"
                        },
                    }
                },
            };
        }

        public override List<ValidationResultMessage> Parse()
        {
            var parseResult = new List<ValidationResultMessage>();

            if (_package != null)
            {
                foreach (var parameter in ConfigurationParameters)
                {
                    parseResult.AddRange(parameter.Validate(_package));
                }
            }
            else
            {
                parseResult.Add(new ValidationResultMessage
                {
                    Body = "Invalid _package path",
                    Status = StatusWords.CRITICAL
                });
            }

            return parseResult;
        }

        public override void ShowResult(List<ValidationResultMessage> messages)
        {
            foreach (var message in messages)
            {
                Console.Write(message.Offset);

                if (message.Status == StatusWords.OK)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("OK : ");
                }
                else if (message.Status == StatusWords.WARN)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("WARN : ");
                }
                else if (message.Status == StatusWords.ERR)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ERROR : ");
                }
                else if (message.Status == StatusWords.CRITICAL)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("CRITICAL : ");
                }

                Console.ResetColor();
                Console.WriteLine(message.Body);
            }
        }
    }
}