using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class NumberPairGenerator
    {
        public Color majorColor;
        public Color minorColor;

        public override string ToString()
        {
        	return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }        

		/// Given the two colors the function returns the pair number corresponding to them

        public static int GetPairNumberFromColor(NumberPairGenerator pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < ColorPairGenerator.colorMapMajor.Length; i++)
            {
                if (ColorPairGenerator.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < ColorPairGenerator.colorMapMinor.Length; i++)
            {
                if (ColorPairGenerator.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * ColorPairGenerator.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}