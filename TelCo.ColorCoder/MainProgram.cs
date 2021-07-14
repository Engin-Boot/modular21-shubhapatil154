using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{ 
	public class MainProgram
	{
		
		/// Test code for the class
        public static void Main(string[] args)
        {
			///printing reference color manual
		ColorReferenceManual.printColorManual();
            int pairNumber = 4;
            NumberPairGenerator testPair1 = ColorPairGenerator.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = ColorPairGenerator.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorPairGenerator.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);

            NumberPairGenerator testPair2 = new NumberPairGenerator() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = NumberPairGenerator.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new NumberPairGenerator() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = NumberPairGenerator.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
			
        }
	}
}