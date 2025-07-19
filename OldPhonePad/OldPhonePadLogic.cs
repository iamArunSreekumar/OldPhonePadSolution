using System;
using System.Collections.Generic;
using System.Text;

namespace OldPhonePad
{
    public static class OldPhonePadLogic
    {
        private static readonly Dictionary<char, string> Keypad = new()
        {
            { '1', "" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };

        public static string ParseInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var output = new StringBuilder();
            var sequence = new StringBuilder();
            char? lastChar = null;

            foreach (char ch in input)
            {
                if (ch == '#')
                {
                    Commit(sequence, output);
                    break;
                }
                else if (ch == '*')
                {
                    if (sequence.Length > 0)
                        sequence.Clear();
                    else if (output.Length > 0)
                        output.Remove(output.Length - 1, 1);
                }
                else if (ch == ' ')
                {
                    Commit(sequence, output);
                }
                else if (char.IsDigit(ch))
                {
                    if (lastChar != null && ch != lastChar)
                        Commit(sequence, output);
                    sequence.Append(ch);
                    lastChar = ch;
                }
            }

            return output.ToString();
        }

        private static void Commit(StringBuilder sequence, StringBuilder output)
        {
            if (sequence.Length == 0)
                return;

            char key = sequence[0];
            int pressCount = sequence.Length;

            if (Keypad.TryGetValue(key, out var chars) && chars.Length > 0)
            {
                int index = (pressCount - 1) % chars.Length;
                output.Append(chars[index]);
            }

            sequence.Clear();
        }
    }
}
