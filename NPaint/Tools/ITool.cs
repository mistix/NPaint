using System.Drawing;

namespace NPaint.Tools
{
    public interface ITool
    {
        void Draw(Graphics gc);
        void StartPoint(Point p);
        void CurrentPoint(Point p);
        void EndPoint(Point p);
        Color BgColor { get; set; }
        Color FgColor { get; set; }
    }
}
