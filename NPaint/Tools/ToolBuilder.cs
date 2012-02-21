using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NPaint
{
    public class ToolBuilder
    {
        #region Fields
        private Commands.ICommand _cmd;
        private Tools.ITool _tool;
        public enum ToolList { LineTool };
        private ToolList _lastTool;
        #endregion

        public ToolBuilder()
        {
            _tool = new Tools.LineTool();
            _cmd = new Commands.LineCommand((Tools.LineTool)_tool);
            _lastTool = ToolList.LineTool;
        }

        /// <summary>
        /// Create new instance of tool for creating lines
        /// </summary>
        /// <returns></returns>
        public Commands.ICommand CreateLineTool()
        {
            _tool = new Tools.LineTool();
            _cmd = new Commands.LineCommand((Tools.LineTool)_tool);
            _lastTool = ToolList.LineTool;
            return _cmd; 
        }

        /// <summary>
        /// Creates new tool after last tool was been used
        /// </summary>
        /// <returns>new instance of ToolArgs</returns>
        public Commands.ICommand CreateLastTool()
        {
            switch (_lastTool)
            {
                case ToolList.LineTool:
                    CreateLineTool();
                    break;
                default:
                    throw new ArgumentException("Bad argument!");
            }
            return _cmd;
        }
    }
}
