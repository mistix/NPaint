using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NPaint.Commands
{
    public class LineCommand : ICommand
    {
        #region Fields
        private Tools.LineTool _lineTool;
        #endregion

        public LineCommand(Tools.LineTool lineTool)
        {
            _lineTool = lineTool;
        }

        public Tools.ITool Tool
        {
            get { return _lineTool;  }
        }

        public void Execute(Graphics graphic)
        {
            _lineTool.Draw(graphic);
        }

        public void Unexecute(Graphics graphic)
        {
            throw new NotImplementedException();
        }
    }
}
