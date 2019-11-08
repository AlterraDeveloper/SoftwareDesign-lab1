using System;
using System.Collections.Generic;
using SoftwareDesign_lab1.Entities;
using SoftwareDesign_lab1.Enums;

namespace SoftwareDesign_lab1.Parsers
{
    public abstract class Parser
    {
        protected Package Package;

        protected List<ConfigurationParameter> ConfigurationParameters;
        public virtual List<ValidationResultMessage> Parse()
        {
            var parseResult = new List<ValidationResultMessage>();

            if (Package != null)
            {
                foreach (var parameter in ConfigurationParameters)
                {
                    parseResult.AddRange(parameter.Validate(Package));
                }
            }
            else
            {
                parseResult.Add(new ValidationResultMessage
                {
                    Body = "Invalid package path",
                    Status = StatusWords.CRITICAL
                });
            }

            return parseResult;
        }
        public virtual void ShowResult(List<ValidationResultMessage> messages)
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