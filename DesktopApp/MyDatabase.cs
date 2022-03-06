using DesktopApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    class MyDatabase
    {
        public List<TShirt> TShirts { get; set; }
        public MyDatabase()
        {
            TShirt s1 = new TShirt(Color.GREEN, Size.L, Fabric.CASHMERE);
            TShirt s2 = new TShirt(Color.BLUE, Size.M, Fabric.COTTON);
            TShirt s3 = new TShirt(Color.RED, Size.S, Fabric.LINEN);
            TShirt s4 = new TShirt(Color.BLUE, Size.M, Fabric.POLYESTER);
            TShirt s5 = new TShirt(Color.GREEN, Size.XS, Fabric.COTTON);
            TShirt s6 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt s7 = new TShirt(Color.GREEN, Size.L, Fabric.COTTON);
            TShirt s8 = new TShirt(Color.BLUE, Size.S, Fabric.LINEN);
            TShirt s9 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt s10 = new TShirt(Color.RED, Size.L, Fabric.COTTON);
            TShirt s11 = new TShirt(Color.RED, Size.M, Fabric.CASHMERE);
            TShirt s12 = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            TShirt s13 = new TShirt(Color.INDIGO, Size.L, Fabric.COTTON);
            TShirt s14 = new TShirt(Color.RED, Size.S, Fabric.LINEN);
            TShirt s15 = new TShirt(Color.BLUE, Size.S, Fabric.COTTON);
            TShirt s16 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt s17 = new TShirt(Color.RED, Size.XS, Fabric.LINEN);
            TShirt s18 = new TShirt(Color.BLUE, Size.XS, Fabric.POLYESTER);
            TShirt s19 = new TShirt(Color.RED, Size.L, Fabric.POLYESTER);
            TShirt s20 = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            TShirt s21 = new TShirt(Color.GREEN, Size.L, Fabric.CASHMERE);
            TShirt s22 = new TShirt(Color.BLUE, Size.M, Fabric.COTTON);
            TShirt s23 = new TShirt(Color.RED, Size.S, Fabric.LINEN);
            TShirt s24 = new TShirt(Color.BLUE, Size.M, Fabric.POLYESTER);
            TShirt s25 = new TShirt(Color.GREEN, Size.XS, Fabric.COTTON);
            TShirt s26 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt s27 = new TShirt(Color.GREEN, Size.L, Fabric.COTTON);
            TShirt s28 = new TShirt(Color.BLUE, Size.S, Fabric.LINEN);
            TShirt s29 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt s30 = new TShirt(Color.RED, Size.L, Fabric.COTTON);
            TShirt s31 = new TShirt(Color.RED, Size.M, Fabric.CASHMERE);
            TShirt s32 = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            TShirt s33 = new TShirt(Color.INDIGO, Size.L, Fabric.COTTON);
            TShirt s34 = new TShirt(Color.RED, Size.S, Fabric.LINEN);
            TShirt s35 = new TShirt(Color.BLUE, Size.S, Fabric.COTTON);
            TShirt s36 = new TShirt(Color.BLUE, Size.M, Fabric.CASHMERE);
            TShirt s37 = new TShirt(Color.RED, Size.XS, Fabric.LINEN);
            TShirt s38 = new TShirt(Color.BLUE, Size.XS, Fabric.POLYESTER);
            TShirt s39 = new TShirt(Color.RED, Size.L, Fabric.POLYESTER);
            TShirt s40 = new TShirt(Color.BLUE, Size.L, Fabric.CASHMERE);
            TShirts = new List<TShirt>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, s31, s32, s33, s34, s35, s36, s37, s38, s39, s40 };
        }
    }
}
