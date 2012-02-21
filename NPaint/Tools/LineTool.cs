using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NPaint.Tools
{
    public class LineTool : ITool
    {
        #region Fields
        private Point _sPoint;
        private Point _ePoint;
        private Color _bgColor = Color.Black;
        private Color _fgColor = Color.Black;
        #endregion

        public void Draw(System.Drawing.Graphics gc)
        {
            Pen pen = new Pen(_bgColor);
            gc.DrawLine(pen, _sPoint, _ePoint);
            pen.Dispose();
        }

        public void StartPoint(System.Drawing.Point p)
        {
            _sPoint = p;
        }

        public void EndPoint(System.Drawing.Point p)
        {
            _ePoint = p;
        }

        public void CurrentPoint(Point p)
        {
            _ePoint = p;
        }

        #region Colors operation
        /// <summary>
        /// Set/Get background color
        /// </summary>
        public Color BgColor
        {
            get { return _bgColor; }
            set { _bgColor = value; }
        }

        /// <summary>
        /// Set/Get foreground color
        /// </summary>
        public Color FgColor
        {
            get { return _fgColor; }
            set { _fgColor = value; }
        }
        #endregion
    }
}
