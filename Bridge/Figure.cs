using Bridge.Common;
using Bridge.Lines;
using Bridge.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Figure
    {
        public static void Draw(Form form, Shape shape, LineStyle line, Color color)
        {
            shape.implementor = line;
            shape.Draw(form, color);
        }
    }
}
