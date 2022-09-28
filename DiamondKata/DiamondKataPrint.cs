using DiamondKata;
using DiamondPrintingCode;
using System.Text;

DiamondKataProgram e = new DiamondKataProgram();
Console.WriteLine("Please enter a capital alphabet character");
string input = Console.ReadLine();
string result = e.Print(input);
Console.WriteLine(result);
    
