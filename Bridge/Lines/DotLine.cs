using System.Drawing;
using System.Drawing.Drawing2D;

namespace Bridge.Lines
{
    class DotLine : LineStyle
    {
        public override Pen Draw(Color color)
        {
            return new Pen(color) { DashStyle = DashStyle.Dot };
        }
    }
}
