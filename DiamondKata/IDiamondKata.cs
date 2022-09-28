using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondPrintingCode
{
    public interface IDiamondKata
    {
        /// <summary>
        /// This function checks if the input alphabet is a single character and throws an exception it it gets more than one input alphabet
        /// </summary>
        /// <param name="input">string Required</param>
        /// <returns>string return</returns>
        public string Print(string input);

        /// <summary>
        /// It calls the helper functions to create the pattern and return the pattern
        /// </summary>
        /// <param name="input">char Required</param>
        /// <returns>string return</returns>
        public string PrintDiamond(char input);

        /// <summary>
        /// Function to create every halves of diamond
        /// </summary>
        /// <param name="middleCharacter">char Required</param>
        /// <returns>List of string return</returns>
        public List<string> CreateHalfDiamonds(char middlecharacter);

        /// <summary>
        /// Function to adjust the characters and the spaces
        /// </summary>
        /// <param name="Leftspaces">int required</param>
        /// <param name="character">int required</param>
        /// <param name="MiddleSpaces">int required</param>
        /// <returns>string return</returns>
        public string AdjustSpacesAndCharacters_Diamond(int Leftspaces, int character, int MiddleSpaces);

        /// <summary>
        /// Function to combine upper and lower halves of diamond
        /// </summary>
        /// <param name="halfDiamondRawPattern">List of string required</param>
        /// <returns>string return</returns>
        public string CombineHalfDiamondPatterns(List<string> halfDiamondRawPattern);

        /// <summary>
        /// it checks if the input is capital Alphabets or not
        /// </summary>
        /// <param name="input">char Required</param>
        /// <returns>boolean return</returns>
        public Boolean InputCheck(char input);

        /// <summary>
        /// Function returns count of alphabets in the pattern
        /// </summary>
        /// <param name="input">char required</param>
        /// <returns>string returns</returns>
        public string CountOfAlphabets_InPattern(char input);

        /// <summary>
        /// Function returns count of given alphabets in the pattern
        /// </summary>
        /// <param name="input"></param>
        /// <param name="alphabet"></param>
        /// <returns></returns>
        public int CountOfGivenAlphabet_InPattern(char input, char alphabet);
    }
}
