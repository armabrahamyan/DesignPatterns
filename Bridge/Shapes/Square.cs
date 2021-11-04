using Bridge.Common;
using Bridge.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    class Square : Shape
    {
        public override void Draw(Form form, Color color)
        {
            base.Draw(form, color);

            graphics.DrawRectangle(pen, new Rectangle(1, 1, 10, 10));
        }
    }
}
