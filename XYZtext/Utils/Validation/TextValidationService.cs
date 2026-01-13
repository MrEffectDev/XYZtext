using System.Collections.Generic;
using System;
using System.Linq;
using System.Globalization;

namespace xyztext.Utils.Validation
{
    public class TextValidationService
    {

        private static readonly HashSet<string> _validVarMethods = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "VAR", "WAIT", "~" };

        private static readonly HashSet<string> _validVariableNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "COLOR","TRNAME","PKNAME","PKNICK","TYPE","LOCATION","ABILITY","MOVE","ITEM1","ITEM2","sTRBAG","BOX","EVSTAT",
            "OPOWER","RIBBON","MIINAME","WEATHER","TRNICK","1stchrTR","SHOUTOUT","BERRY","REMFEEL","REMQUAL","WEBSITE",
            "CHOICECOS","GSYNCID","PRVIDSAY","BTLTEST","GENLOC","CHOICEFOOD","HOTELITEM","TAXISTOP","MAISTITLE",
            "ITEMPLUR0","ITEMPLUR1","GENDBR","NUMBRNCH","iCOLOR2","iCOLOR3","NUM1","NUM2","NUM3","NUM4","NUM5",
            "NUM6","NUM7","NUM8","NUM9"
        };

        public ValidationResult ValidateLines(string[] lines)
        {
            var result = new ValidationResult();
            if (lines == null)
            {
                lines = Array.Empty<string>();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i] ?? string.Empty;

                if (line.Length > 70 && !line.Contains("\\n"))
                {
                    result.Messages.Add(new ValidationMessage { LineIndex = i, IsError = false, Message = $"Line length is {line.Length} (>70) and has no \\n" });
                    result.WarningLines.Add(i);
                }

                for (int j = 0; j < line.Length; j++)
                {
                    char symbol = line[j];

                    if (symbol == '\\')
                    {
                        if (j + 1 >= line.Length)
                        {
                            result.Messages.Add(new ValidationMessage { LineIndex = i, IsError = true, Message = "Trailing backslash (\\) at end of line" });
                            result.ErrorLines.Add(i);
                            break;
                        }

                        char nextSymbol = line[j + 1];
                        if (!(nextSymbol == 'n' || nextSymbol == 'r' || nextSymbol == 'c'))
                        {
                            result.Messages.Add(new ValidationMessage { LineIndex = i, IsError = true, Message = $"Invalid escape sequence \\{nextSymbol} — allowed: \\n, \\r, \\c" });
                            result.ErrorLines.Add(i);
                            break;
                        }

                        j++;
                    }
                    else if (symbol == '[')
                    {
                        int endIndex = line.IndexOf(']', j + 1);
                        if (endIndex == -1)
                        {
                            result.Messages.Add(new ValidationMessage { LineIndex = i, IsError = true, Message = "Unclosed '[' found" });
                            result.ErrorLines.Add(i);
                            break;
                        }

                        string inside = line.Substring(j + 1, endIndex - j - 1);
                        if (string.IsNullOrEmpty(inside))
                        {
                            result.Messages.Add(new ValidationMessage { LineIndex = i, IsError = true, Message = "Empty [] block" });
                            result.ErrorLines.Add(i);
                            j = endIndex;
                            continue;
                        }

                        string method = inside.Split(new[] {' '}, 2)[0];
                        if (!_validVarMethods.Contains(method))
                        {
                            result.Messages.Add(new ValidationMessage { LineIndex = i, IsError = true, Message = $"Unknown variable method '{method}'" });
                            result.ErrorLines.Add(i);
                            j = endIndex;
                            continue;
                        }

                        if (string.Equals(method, "VAR", StringComparison.OrdinalIgnoreCase))
                        {
                            string remainder = inside.Length > method.Length ? inside.Substring(method.Length).Trim() : string.Empty;
                            if (string.IsNullOrEmpty(remainder))
                            {
                                result.Messages.Add(new ValidationMessage { LineIndex = i, IsError = true, Message = "VAR requires a type (e.g. VAR COLOR or VAR 0100)" });
                                result.ErrorLines.Add(i);
                                j = endIndex;
                                continue;
                            }

                            string variableName = remainder;
                            int parameterIndex = remainder.IndexOf('(');
                            if (parameterIndex >= 0)
                            {
                                variableName = remainder.Substring(0, parameterIndex).Trim();
                            }

                            if (string.IsNullOrEmpty(variableName))
                            {
                                result.Messages.Add(new ValidationMessage { LineIndex = i, IsError = true, Message = "Invalid VAR name" });
                                result.ErrorLines.Add(i);
                                j = endIndex;
                                continue;
                            }
                            if (!_validVariableNames.Contains(variableName))
                            {
                                if (!ushort.TryParse(variableName, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out _))
                                {
                                    result.Messages.Add(new ValidationMessage { LineIndex = i, IsError = true, Message = $"Unknown VAR name '{variableName}' and not a valid hex code" });
                                    result.ErrorLines.Add(i);
                                }
                            }
                        }
                        j = endIndex;
                    }
                    else if (symbol == ']')
                    {
                        result.Messages.Add(new ValidationMessage
                        {
                            LineIndex = i,
                            IsError = true,
                            Message = "Unmatched ']' found"
                        });

                        result.ErrorLines.Add(i);
                        break;
                    }

                }
            }

            if (result.ErrorLines.Any()) result.Status = ValidationStatus.Red;
            else if (result.WarningLines.Any()) result.Status = ValidationStatus.Yellow;
            else result.Status = ValidationStatus.Green;

            return result;
        }
    }
}