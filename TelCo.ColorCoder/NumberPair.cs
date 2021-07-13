using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
   
    class NumberPair
    {
        public Color majorColor;
        public Color minorColor;

        public override string ToString()
        {
        	return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }        

	/// Given the two colors the function returns the pair number corresponding to them

        public static int GetPairNumberFromColor(NumberPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < ColorPair.colorMapMajor.Length; i++)
            {
                if (ColorPair.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < ColorPair.colorMapMinor.Length; i++)
            {
                if (ColorPair.colorMapMinor[i] == pair.minorColor)
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
            return (majorIndex * ColorPair.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}