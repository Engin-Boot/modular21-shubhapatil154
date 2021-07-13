using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// class defined to hold the two colors of clor pair
    class ColorReferenceManual
    {
        public static void printColorManual(){
		for(num1 = 0; num1 < 5; num1++){
			for(num2 = 0; num2 < 5; num2++){
				Console.WriteLine("[In] Colors: Major{0} - Minor{1}\n", NumberPair.colorMapMajor[num1], NumberPair.colorMapMinor[num2]);
			}
		}
	
    }
}