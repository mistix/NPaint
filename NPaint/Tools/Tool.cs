using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using NPaint.Commands;

namespace NPaint.Tools
{
    /// <summary>
    /// Main class for choising 
    /// </summary>
    public class Tool
    {
        #region Fields
        private ICommand _activeCmd;
        private CommandHistory _cmdHistory;
        #endregion

        public Tool(CommandHistory commandHistory)
        {
            _cmdHistory = commandHistory;
        }

        public ICommand ActiveTool
        {
            get { return _activeCmd; }
            set { _activeCmd = value; }
        }

        public void Draw()
        {
            _cmdHistory.AddCommand(_activeCmd);
        }

        public void StartAt(Point point)
        {
            _activeCmd.Tool.StartPoint(point);
        }

        public void CurrentPos(Point point)
        {
            _activeCmd.Tool.CurrentPoint(point);
        }

        public void EndAt(Point point)
        {
            _activeCmd.Tool.EndPoint(point);
        }
    }
}
