using CliMenu.Source.Components.Helpers;
using CliMenu.Source.Interfaces;

namespace CliMenu.Source.Components.Base;

internal abstract class FocusableBaseComponent<TExecutable, TDisplayer, TInputHandler>
    : BaseComponent<TExecutable, TDisplayer, TInputHandler>
    where TExecutable : NoExecutable, IExecutable
    where TDisplayer : NoDisplay, IDisplayer
    where TInputHandler : NoInputHandler, IInputHandler
{
    internal FocusableBaseComponent(string name) : base(name) { }
}