using System.Drawing;
using System.Drawing.Drawing2D;

namespace Bridge.Lines
{
    class DashDotLine : LineStyle
    {
        public override Pen Draw(Color color)
        {
            return new Pen(color) { DashStyle = DashStyle.Dot };
        }
    }
}
