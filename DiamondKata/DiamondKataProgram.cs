using DiamondPrintingCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DiamondKata
{
    public class DiamondKataProgram : IDiamondKata
    {
        private const char firstLetter = 'A';
        private const char lastLetter = 'Z';
        private const char space = ' ';
        private const string newLine = "\n";
        string ATOZ = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        /// <summary>
        /// This function checks if the input alphabet is a single character and throws an exception it it gets more than one input alphabet
        /// </summary>
        /// <param name="input">string Required</param>
        /// <returns>string return</returns>
        public string Print(string input)
        {
            string output = " ";
            try
            {
                if (input.Length > 1)
                {
                    throw new ArgumentException("Please enter only one length alphabet");
                }
                output = PrintDiamond(char.Parse(input));
            }
            catch (ArgumentException ex)
            {
                output = ex.Message;
            }
            return output;
        }

        /// <summary>
        /// It calls the helper functions to create the pattern and return the pattern
        /// </summary>
        /// <param name="input">char Required</param>
        /// <returns>string return</returns>
        public string PrintDiamond(char input)
        {
            if (InputCheck(input))
            {
                if (input.Equals(firstLetter))
                    return "A";
                return CombineHalfDiamondPatterns(CreateHalfDiamonds(input));
            }
            return input + " is outside the valid range A..Z";
        }

        /// <summary>
        /// it checks if the input is capital Alphabets or not
        /// </summary>
        /// <param name="input">char Required</param>
        /// <returns>boolean return</returns>
        public Boolean InputCheck(char input)
        {
            if (ATOZ.Contains(input))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function to create every halves of diamond
        /// </summary>
        /// <param name="middleCharacter">char Required</param>
        /// <returns>List of string return</returns>
        public List<string> CreateHalfDiamonds(char middleCharacter)
        {
            List<string> lines = new List<string>();
            int leftSpaces = middleCharacter - firstLetter;
            int length = ATOZ.IndexOf(middleCharacter) + 1;
            int middleSpaces = 1;
            foreach (char character in ATOZ.Substring(0, length))
            {
                lines.Add(AdjustSpacesAndCharacters_Diamond(leftSpaces, character, middleSpaces));
                length++;
                leftSpaces--;
                middleSpaces = length - leftSpaces - 2;
            }
            return lines;
        }

        /// <summary>
        /// Function to combine upper and lower halves of diamond
        /// </summary>
        /// <param name="halfDiamondRawPattern">List of string required</param>
        /// <returns>string return</returns>
        public string CombineHalfDiamondPatterns(List<string> halfDiamondRawPattern)
        {
            string halfDiamond = string.Join(newLine, halfDiamondRawPattern);
            halfDiamondRawPattern.Reverse();
            return halfDiamond + newLine + string.Join(newLine, halfDiamondRawPattern.Skip(1));
        }

        /// <summary>
        /// Function to adjust the characters and the spaces
        /// </summary>
        /// <param name="leftSpaces">int required</param>
        /// <param name="character">int required</param>
        /// <param name="middleSpaces">int required</param>
        /// <returns>string return</returns>
        public string AdjustSpacesAndCharacters_Diamond(int leftSpaces, int character, int middleSpaces)
        {
            char letter = Convert.ToChar(character);
            string line = string.Empty.PadLeft(leftSpaces, space) + letter;
            if (letter != firstLetter)
            {
                line += string.Empty.PadLeft(middleSpaces, space) + letter;
            }
            return line;
        }

        /// <summary>
        /// Function returns count of alphabets in the pattern
        /// </summary>
        /// <param name="input">char required</param>
        /// <returns>string returns</returns>
        public string CountOfAlphabets_InPattern(char input)
        {
            string countLetters = PrintDiamond(input);
            return countLetters.Count(char.IsLetter).ToString();
        }

        /// <summary>
        /// Function returns count of given alphabets in the pattern
        /// </summary>
        /// <param name="input"></param>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public int CountOfGivenAlphabet_InPattern(char input, char alphabet)
        {
            string countLetters = PrintDiamond(input);

            if (Char.IsLetter(alphabet))
            {
                if (ATOZ.Contains(alphabet))
                    return countLetters.Count(f => (f == alphabet));
            }
            return 0;
        }
    }
}
