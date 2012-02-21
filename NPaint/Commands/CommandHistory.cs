using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace NPaint.Commands
{
    public class CommandHistory
    {
        #region Fields
        private List<ICommand> _cmdList;
        private const int _maxCap = 10;
        private int _index = 0;
        #endregion

        public CommandHistory()
        {
            _cmdList = new List<ICommand>();
        } 

        /// <summary>
        /// Adding new command to commands list
        /// </summary>
        /// <param name="command">Executed command</param>
        public void AddCommand(ICommand command)
        {
            if (_index < _cmdList.Count)
            {
                int count = _cmdList.Count - _index;
                _cmdList.RemoveRange(_index, count);
            }
            else
            {
                _cmdList.Add(command);
                _index++;
            }
        }

        /// <summary>
        /// Returns list of commands to execute
        /// </summary>
        public List<ICommand> CommandList
        {
            get { return _cmdList; }
        }

        /// <summary>
        /// Execute all avaliable commands in list
        /// </summary>
        /// <param name="gc">Graphic context</param>
        public void ExecuteCommands(System.Drawing.Graphics gc)
        {
            for (int i = 0; i < _index; i++)
            {
                _cmdList[i].Execute(gc);
            }
        }

        /// <summary>
        /// One command forward
        /// </summary>
        public void Redo()
        {
            if (_index < _cmdList.Count)
                _index++;
        }

        /// <summary>
        /// One command backward
        /// </summary>
        public void Undo()
        {
            if ((_index < 0) && (_cmdList.Count > 0))
                _index--;
        }
    }
}
