using System;
using System.Text;
using System.Collections.Generic;

public class PhonePadTranslator
{
    private static readonly Dictionary<char, string> keyMap = new Dictionary<char, string>
    {
        {'1', "&'("},
        {'2', "ABC"},
        {'3', "DEF"},
        {'4', "GHI"},
        {'5', "JKL"},
        {'6', "MNO"},
        {'7', "PQRS"},
        {'8', "TUV"},
        {'9', "WXYZ"},
        {'0', " "},
        {'*', ""},
        {'#', ""}
    };

    public static string OldPhonePad(string input)
    {
        StringBuilder output = new StringBuilder();
        int count = 0;
        char currentKey = input[0];

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (c == '#')
            {
                if (currentKey != ' ' && currentKey != '*' && currentKey != '#')
                {
                    string possibleChars = keyMap[currentKey];
                    output.Append(possibleChars[(count - 1) % possibleChars.Length]);
                }
                break;
            }
            if (c == ' ')
            {
                if (currentKey != ' ' && currentKey != '*' && currentKey != '#')
                {
                    string possibleChars = keyMap[currentKey];
                    output.Append(possibleChars[(count - 1) % possibleChars.Length]);
                }
                currentKey = c;
                count = 0;
            }
            else
            {
                if (currentKey == c)
                {
                    count++;
                }
                else
                {
                    if (currentKey != ' ' && currentKey != '*' && currentKey != '#')
                    {
                        string possibleChars = keyMap[currentKey];
                        output.Append(possibleChars[(count - 1) % possibleChars.Length]);
                    }
                    currentKey = c;
                    count = 1;
                }
            }
            if (c == '*')
            {
                if (output.Length > 0)
                {
                    output.Length--;
                }
                continue;
            }
        }

        return output.ToString();
    }
}
