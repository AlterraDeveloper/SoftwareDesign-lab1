using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using SoftwareDesign_lab1.Entities;
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
                    Attributes = null,
                    Validator = new FileExistenceValidator(Package)
                },
                new ConfigurationParameter
                {
                    Name = "memorylimit",
                    IsRequired = true,
                    Attributes = null,
                    Validator = new ExistenceValidator(Package)
                },
                new ConfigurationParameter
                {
                    Name = "timelimit",
                    IsRequired = true,
                    Attributes = null,
                    Validator = new ExistenceValidator(Package)
                },
                new ConfigurationParameter
                {
                    Name = "testversion",
                    IsRequired = true,
                    Attributes = null,
                    Validator = new ExistenceValidator(Package)
                },
                new ConfigurationParameter
                {
                    Name = "runtype",
                    IsRequired = true,
                    Attributes = null,
                    Validator = new ExistenceValidator(Package)
                },
                new ConfigurationParameter
                {
                    Name = "test",
                    IsRequired = true,
                    Validator = new ExistenceValidator(Package),
                    Attributes = new List<ConfigurationParameter>
                    {
                        new ConfigurationParameter
                        {
                            Name = "input",
                            IsRequired = true,
                            Attributes = null,
                            Validator = new FileExistenceValidator(Package)
                        },
                        new ConfigurationParameter
                        {
                            Name = "output",
                            IsRequired = true,
                            Attributes = null,
                            Validator = new FileExistenceValidator(Package)
                        },
                        new ConfigurationParameter
                        {
                            Name = "groupid",
                            IsRequired = false,
                            Attributes = null,
                            Validator = new ExistenceValidator(Package)
                        },
                        new ConfigurationParameter
                        {
                            Name = "points",
                            IsRequired = false,
                            Attributes = null,
                            Validator = new ExistenceValidator(Package)
                        },
                    }
                },
                new ConfigurationParameter
                {
                    Name = "interactor",
                    IsRequired = false,
                    Attributes = null,
                    Validator = new FileExistenceValidator(Package)
                },
                new ConfigurationParameter
                {
                    Name = "problem",
                    IsRequired = false,
                    Attributes = null,
                    Validator = new FileExistenceValidator(Package)
                },
                new ConfigurationParameter
                {
                    Name = "groups",
                    IsRequired = false,
                    Attributes = null,
                    Validator = new ExistenceValidator(Package)
                },
            };
        }

        public override List<ValidationResultMessage> Parse()
        {
            var parseResult = new List<ValidationResultMessage>();

            if (Package != null)
            {
                foreach (var parameter in ConfigurationParameters)
                {
                    parseResult.Add(parameter.Validator.Validate(parameter));
                }
            }
            else
            {
                parseResult.Add(new ValidationResultMessage
                {
                    Body = "Invalid Package path",
                    Status = StatusWords.CRITICAL
                });
            }

            return parseResult;
        }

        public override void ShowResult(List<ValidationResultMessage> messages)
        {
            foreach (var message in messages)
            {
                if (message.Status == StatusWords.OK)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("OK : ");
                }
                else if (message.Status == StatusWords.WARN)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
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

        private bool ExistingChecker(ConfigurationParameter parameter, XmlElement xRoot)
        {
            var xNode = xRoot.SelectSingleNode(parameter.Name);
            return xNode != null;
        }

        private bool FileExistingChecker(ConfigurationParameter parameter, XmlElement xRoot, DirectoryInfo Package)
        {
            var xNode = xRoot.SelectSingleNode(parameter.Name);

            if (xNode != null)
            {
                if (new DirectoryInfo(Path.Combine(Package.FullName, parameter.Name)).Exists)
                {
                    return true;
                }
            }

            return false;
        }
    }
}