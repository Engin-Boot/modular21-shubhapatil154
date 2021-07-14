using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// class print the color manual for reference
    class ColorReferenceManual
    {
        public static void printColorManual()
		{
			for(int num1 = 0; num1 < ColorPairGenerator.colorMapMajor.Length; num1++)
			{
				for(int num2 = 0; num2 < ColorPairGenerator.colorMapMinor.Length; num2++)
				{
					Console.WriteLine("[In] Colors: Major{0} - Minor{1}\n", ColorPairGenerator.colorMapMajor[num1], ColorPairGenerator.colorMapMinor[num2]);
				}
			}

		}
	}
}	