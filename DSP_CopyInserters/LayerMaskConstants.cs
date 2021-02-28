using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSP_Mods.CopyInserters
{
    /// <summary>
    /// Constants for Unity Layer masks, allows building masks by bitwise or'ing layer constants together
    /// </summary>
    public static class LayerMaskConstants
    {
        public static readonly int layer1 =  Convert.ToInt32("0000000000000000000000000000001", 2); //2          2^1
        public static readonly int layer2 =  Convert.ToInt32("0000000000000000000000000000010", 2); //4          2^2
        public static readonly int layer3 =  Convert.ToInt32("0000000000000000000000000000100", 2); //8          2^3
        public static readonly int layer4 =  Convert.ToInt32("0000000000000000000000000001000", 2); //16         2^4
        public static readonly int layer5 =  Convert.ToInt32("0000000000000000000000000010000", 2); //32         2^5
        public static readonly int layer6 =  Convert.ToInt32("0000000000000000000000000100000", 2); //64         2^6
        public static readonly int layer7 =  Convert.ToInt32("0000000000000000000000001000000", 2); //128        2^7
        public static readonly int layer8 =  Convert.ToInt32("0000000000000000000000010000000", 2); //256        2^8
        public static readonly int layer9 =  Convert.ToInt32("0000000000000000000000100000000", 2); //512        2^9
        public static readonly int layer10 = Convert.ToInt32("0000000000000000000001000000000", 2); //1024       2^10
        public static readonly int layer11 = Convert.ToInt32("0000000000000000000010000000000", 2); //2048       2^11
        public static readonly int layer12 = Convert.ToInt32("0000000000000000000100000000000", 2); //4096       2^12
        public static readonly int layer13 = Convert.ToInt32("0000000000000000001000000000000", 2); //8192       2^13
        public static readonly int layer14 = Convert.ToInt32("0000000000000000010000000000000", 2); //16384      2^14
        public static readonly int layer15 = Convert.ToInt32("0000000000000000100000000000000", 2); //32768      2^15
        public static readonly int layer16 = Convert.ToInt32("0000000000000001000000000000000", 2); //65536      2^16
        public static readonly int layer17 = Convert.ToInt32("0000000000000010000000000000000", 2); //131072     2^17
        public static readonly int layer18 = Convert.ToInt32("0000000000000100000000000000000", 2); //262144     2^18
        public static readonly int layer19 = Convert.ToInt32("0000000000001000000000000000000", 2); //524288     2^19
        public static readonly int layer20 = Convert.ToInt32("0000000000010000000000000000000", 2); //1048576    2^20
        public static readonly int layer21 = Convert.ToInt32("0000000000100000000000000000000", 2); //2097152    2^21
        public static readonly int layer22 = Convert.ToInt32("0000000001000000000000000000000", 2); //4194304    2^22
        public static readonly int layer23 = Convert.ToInt32("0000000010000000000000000000000", 2); //8388608    2^23
        public static readonly int layer24 = Convert.ToInt32("0000000100000000000000000000000", 2); //16777216   2^24
        public static readonly int layer25 = Convert.ToInt32("0000001000000000000000000000000", 2); //33554432   2^25
        public static readonly int layer26 = Convert.ToInt32("0000010000000000000000000000000", 2); //67108864   2^26
        public static readonly int layer27 = Convert.ToInt32("0000100000000000000000000000000", 2); //134217728  2^27
        public static readonly int layer28 = Convert.ToInt32("0001000000000000000000000000000", 2); //268435456  2^28
        public static readonly int layer29 = Convert.ToInt32("0010000000000000000000000000000", 2); //536870912  2^29
        public static readonly int layer30 = Convert.ToInt32("0100000000000000000000000000000", 2); //1073741824 2^30
        public static readonly int layer31 = Convert.ToInt32("1000000000000000000000000000000", 2); //2147483648 2^31
        //public static readonly int layer32 = Convert.ToInt32("10000000000000000000000000000000", 2); //4294967296 2^32
    }
}
