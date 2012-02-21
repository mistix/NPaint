
namespace NPaint.Commands
{
    public interface ICommand
    {
        void Execute(System.Drawing.Graphics graphic);
        void Unexecute(System.Drawing.Graphics graphic);
        Tools.ITool Tool { get; }
    }
}
