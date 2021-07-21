using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// class defined to hold the two colors of clor pair
    class ColorPairGenerator
    {
        /// Array of Major colors
        public static Color[] colorMapMajor;
        /// Array of minor colors
        public static Color[] colorMapMinor;

		/// Static constructor required to initialize static variable
        static ColorPairGenerator()
            {
                colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
                colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
            }

        /// Given a pair number function returns the major and minor colors in that order

        public static NumberPairGenerator GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = colorMapMinor.Length;
            int majorSize = colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            
            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            NumberPairGenerator pair = new NumberPairGenerator(){ 
                majorColor = colorMapMajor[majorIndex],minorColor = colorMapMinor[minorIndex] 
            };
            
            // return the value
            return pair;
        }

    }
}
