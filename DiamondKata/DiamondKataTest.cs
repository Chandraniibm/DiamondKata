using DiamondKata;
using DiamondPrintingCode;
using Xunit;

namespace DiamondTest
{
  public class DiamondKataTest
    {
        IDiamondKata _diamondPrint;
        public DiamondKataTest()
        {
            _diamondPrint = new DiamondKataProgram();
        }
        
        [Fact]
        public void Return_Single_Character_When_OneCharacter_Passsed()
        {
            const string diamond = "A";
            Assert.Equal(diamond, _diamondPrint.Print("A"));
        }

        [Fact]
        public void Input_isSinglecharacter()
        {
            Assert.Equal("Please enter only one length alphabet", _diamondPrint.Print("AB"));
        }

        [Fact]
        public void Input_Is_From_AtoZ()
        {
            Assert.Equal(true, _diamondPrint.InputCheck('A'));
        }

        [Fact]
        public void Input_Is_Not_From_AtoZ()
        {
            Assert.Equal(false, _diamondPrint.InputCheck('&'));
        }

        [Fact]
        public void PrintDiamond_PatternB_Test()
        {
            const string diamond = " A\n" +
                                   "B B\n" +
                                   " A";
            Assert.Equal(diamond, _diamondPrint.Print("B"));
        }

        [Fact]
        public void PrintDiamond_PatternC_Test()
        {
            const string diamond = "  A\n" +
                                   " B B\n" +
                                   "C   C\n" +
                                   " B B\n" +
                                   "  A";
            Assert.Equal(diamond, _diamondPrint.Print("C"));
        }
        
        [Fact]
        public void PrintCountAlphabets_InPatternB()
        {
            string diamond = "4";
            Assert.Equal(diamond, _diamondPrint.CountOfAlphabets_InPattern('B'));
        }

        [Fact]
        public void PrintCountAlphabets_InPatternC()
        {
            string diamond = "8";
            Assert.Equal(diamond, _diamondPrint.CountOfAlphabets_InPattern('C'));
        }

      [Fact]
        public void PrintCountof_B_Alphabet_InPatternC()
        {
            int diamond = 4;
            Assert.Equal(diamond, _diamondPrint.CountOfGivenAlphabet_InPattern('C','B'));
        }

        [Fact]
        public void PrintCountof_a_Alphabet_InPatternC()
        {
            int diamond = 0;
            Assert.Equal(diamond, _diamondPrint.CountOfGivenAlphabet_InPattern('C', 'a'));
        }
    }
}
