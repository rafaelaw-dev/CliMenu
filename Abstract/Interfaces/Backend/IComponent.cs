using CliMenu.Abstract.Interfaces.Display;

namespace CliMenu.Abstract.Interfaces.Backend
{
    /// <summary>
    /// Interface for components that are both displayable and executable.
    /// </summary>
    public interface IComponent : IDisplayable, IExecutable {}
}
