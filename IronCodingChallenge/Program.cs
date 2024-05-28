using System;
using System.Text;

public class OldPhonePad
{
    public static void Main(string[] args)
    {
        // Test cases
        Console.WriteLine(InputString("33#")); // Output: E
        Console.WriteLine(InputString("227*#")); // Output: B
        Console.WriteLine(InputString("4433555 555666#")); // Output: HELLO
        Console.WriteLine(InputString("8 88777444666*664#")); // Output: ?????
    }

    public static string InputString(string input)
    {
        if (string.IsNullOrEmpty(input)) return string.Empty;

        StringBuilder result = new StringBuilder();
        StringBuilder currentSequence = new StringBuilder();
        char? lastChar = null;
        DateTime lastPress = DateTime.MinValue;

        foreach (char c in input)
        {
            if (c == '#')
            {
                if (currentSequence.Length > 0)
                {
                    result.Append(ConvertSequenceToChar(currentSequence.ToString()));
                }
                break;
            }
            if (c == '*')
            {
                if (result.Length > 0)
                {
                    result.Length--; // Remove last character
                }
            }
            else if (c == ' ')
            {
                if (currentSequence.Length > 0)
                {
                    result.Append(ConvertSequenceToChar(currentSequence.ToString()));
                    currentSequence.Clear();
                }
            }
            else
            {
                if (lastChar == c && (DateTime.Now - lastPress).TotalMilliseconds < 1000)
                {
                    currentSequence.Append(c);
                }
                else
                {
                    if (currentSequence.Length > 0)
                    {
                        result.Append(ConvertSequenceToChar(currentSequence.ToString()));
                        currentSequence.Clear();
                    }
                    currentSequence.Append(c);
                }
                lastChar = c;
                lastPress = DateTime.Now;
            }
        }

        return result.ToString();
    }

    private static char ConvertSequenceToChar(string sequence)
    {
        string[] mappings = new string[]
        {
            " ", "1", "ABC2", "DEF3", "GHI4", "JKL5", "MNO6", "PQRS7", "TUV8", "WXYZ9", "*", "0", "#"
        };

        int key = int.Parse(sequence[0].ToString());
        int index = (sequence.Length - 1) % mappings[key].Length;

        return mappings[key][index];
    }
}
