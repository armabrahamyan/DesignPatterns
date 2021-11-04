using Bridge.Lines;
using Bridge.Shapes;
using System;
using System.Drawing;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure.Draw(new Common.Form(), new Square(), new DotLine(), Color.Black);
        }
    }
}
