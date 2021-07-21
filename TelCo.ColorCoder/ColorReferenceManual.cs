using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// class print the color manual for reference
    class ColorReferenceManual
    {
        public static List<int> printColorManual()
		{
            List<int> colorCountList = new List<int>();
            int majorColorsCount = 0,minorColorCount = 0;
			for(int num1 = 0; num1 < ColorPairGenerator.colorMapMajor.Length; num1++)
			{
                majorColorsCount++;
				for(int num2 = 0; num2 < ColorPairGenerator.colorMapMinor.Length; num2++)
				{   
                    minorColorCount++;
					Console.WriteLine("[In] Colors: Major{0} - Minor{1}\n", ColorPairGenerator.colorMapMajor[num1], ColorPairGenerator.colorMapMinor[num2]);
				}
			}
            colorCountList.Add(majorColorsCount);
            colorCountList.Add(minorColorCount);
            // Console.WriteLine("Major color Actual count {0}  Minor color Actual count {1}",ColorPairGenerator.colorMapMajor.Length,ColorPairGenerator.colorMapMinor.Length);
            // Console.WriteLine("Major color count {0}  Minor color count {1}",majorColorsCount,minorColorCount);
            
            return colorCountList;
		}
	}
}