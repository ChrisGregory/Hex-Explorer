using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class HexGrid
    {
        public float Size = 1;
        public float UnitWidth { get => (float) Math.Sqrt(3) * Size; }
        public float UnitHeight { get => 2 * Size; }


    }
}
