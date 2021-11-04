using Bridge.Common;
using Bridge.Lines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    abstract class Shape
    {
        protected Graphics graphics;
        protected Pen pen;
        public LineStyle implementor;

        public virtual void Draw(Form form, Color color)
        {
            graphics = form.CreateGraphics();
            pen = implementor.Draw(color);
        }
    }
}
