using DesktopApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    public class TShirt
    {
        public Color Color;
        public Size Size;
        public Fabric Fabric;
        public decimal Price { get; set; }
        public TShirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }
        public void Output()
        {
            System.Console.WriteLine($"{Size,-15} {Color,-15} {Fabric,-15}");
        }
    }
}
