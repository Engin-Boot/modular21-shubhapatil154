using System;

namespace TelCo.ColorCoder
{
    /// class defined to hold the two colors of clor pair
    class ColorPair
    {
        internal Color majorColor;
        internal Color minorColor;
        public override string ToString()
        {
        	return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }        

        /// Given a pair number function returns the major and minor colors in that order

        /* <param name="pairNumber">Pair number of the color to be fetched</param>
            <returns> The Color Pair corresponding to the given Pair number </returns>*/
        private static ColorPair GetColorFromPairNumber(int pairNumber)
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
            ColorPair pair = new ColorPair() { majorColor = colorMapMajor[majorIndex],
            	minorColor = colorMapMinor[minorIndex] };
            
            // return the value
            return pair;
        }

    }
}