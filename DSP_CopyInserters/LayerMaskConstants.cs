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
        public static readonly int layer1 =  Convert.ToInt32("0000000000000000000000000000001", 2);
        public static readonly int layer2 =  Convert.ToInt32("0000000000000000000000000000010", 2);
        public static readonly int layer3 =  Convert.ToInt32("0000000000000000000000000000100", 2);
        public static readonly int layer4 =  Convert.ToInt32("0000000000000000000000000001000", 2);
        public static readonly int layer5 =  Convert.ToInt32("0000000000000000000000000010000", 2);
        public static readonly int layer6 =  Convert.ToInt32("0000000000000000000000000100000", 2);
        public static readonly int layer7 =  Convert.ToInt32("0000000000000000000000001000000", 2);
        public static readonly int layer8 =  Convert.ToInt32("0000000000000000000000010000000", 2);
        public static readonly int layer9 =  Convert.ToInt32("0000000000000000000000100000000", 2);
        public static readonly int layer10 = Convert.ToInt32("0000000000000000000001000000000", 2);
        public static readonly int layer11 = Convert.ToInt32("0000000000000000000010000000000", 2);
        public static readonly int layer12 = Convert.ToInt32("0000000000000000000100000000000", 2);
        public static readonly int layer13 = Convert.ToInt32("0000000000000000001000000000000", 2);
        public static readonly int layer14 = Convert.ToInt32("0000000000000000010000000000000", 2);
        public static readonly int layer15 = Convert.ToInt32("0000000000000000100000000000000", 2);
        public static readonly int layer16 = Convert.ToInt32("0000000000000001000000000000000", 2);
        public static readonly int layer17 = Convert.ToInt32("0000000000000010000000000000000", 2);
        public static readonly int layer18 = Convert.ToInt32("0000000000000100000000000000000", 2);
        public static readonly int layer19 = Convert.ToInt32("0000000000001000000000000000000", 2);
        public static readonly int layer20 = Convert.ToInt32("0000000000010000000000000000000", 2);
        public static readonly int layer21 = Convert.ToInt32("0000000000100000000000000000000", 2);
        public static readonly int layer22 = Convert.ToInt32("0000000001000000000000000000000", 2);
        public static readonly int layer23 = Convert.ToInt32("0000000010000000000000000000000", 2);
        public static readonly int layer24 = Convert.ToInt32("0000000100000000000000000000000", 2);
        public static readonly int layer25 = Convert.ToInt32("0000001000000000000000000000000", 2);
        public static readonly int layer26 = Convert.ToInt32("0000010000000000000000000000000", 2);
        public static readonly int layer27 = Convert.ToInt32("0000100000000000000000000000000", 2);
        public static readonly int layer28 = Convert.ToInt32("0001000000000000000000000000000", 2);
        public static readonly int layer29 = Convert.ToInt32("0010000000000000000000000000000", 2);
        public static readonly int layer30 = Convert.ToInt32("0100000000000000000000000000000", 2);
        public static readonly int layer31 = Convert.ToInt32("1000000000000000000000000000000", 2);
        //public static readonly int layer32 = Convert.ToInt32("10000000000000000000000000000000", 2);
    }
}
