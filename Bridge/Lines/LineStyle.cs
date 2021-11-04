using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Lines
{
    abstract class LineStyle
    {
        public abstract Pen Draw(Color color); 
    }
}
