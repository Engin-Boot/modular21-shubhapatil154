using System;

namespace TelCo.ColorCoder
{
    /// class defined to hold the two colors of clor pair
    class ColorReferenceManual
    {
        public static void printColorManual(){
		for(num1 = 0; num1 < 5; num1++){
			for(num2 = 0; num2 < 5; num2++){
				Console.WriteLine("Colors: major{0} - minor{1}\n", Program.colorMapMajor[num1], Program.colorMapMinor[num2]);
			}
		}
	}
    }
}