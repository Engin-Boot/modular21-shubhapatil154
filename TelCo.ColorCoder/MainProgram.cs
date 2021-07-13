using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{ 
	class MainProgram{
	///printing the color manual for reference
	ColorReferenceManual.printManual();

	/// Test code for the class
        private static void Main(string[] args){
			int pairNumber = 4;

			NumberPair testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
			Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
			Debug.Assert(testPair1.majorColor == Color.White);
			Debug.Assert(testPair1.minorColor == Color.Brown);

			pairNumber = 5;
			testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
			Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
			Debug.Assert(testPair1.majorColor == Color.White);
			Debug.Assert(testPair1.minorColor == Color.SlateGray);

			pairNumber = 23;
			testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
			Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
			Debug.Assert(testPair1.majorColor == Color.Violet);
			Debug.Assert(testPair1.minorColor == Color.Green);

			NumberPair testPair2 = new NumberPair() { majorColor = Color.Yellow, minorColor = Color.Green };
			pairNumber = NumberPair.GetPairNumberFromColor(testPair2);
			Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
			Debug.Assert(pairNumber == 18);

			testPair2 = new NumberPair() { majorColor = Color.Red, minorColor = Color.Blue };
			pairNumber = NumberPair.GetPairNumberFromColor(testPair2);
			Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
			Debug.Assert(pairNumber == 6);
		}
	}
}