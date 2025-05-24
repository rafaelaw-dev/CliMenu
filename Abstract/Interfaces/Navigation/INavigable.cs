using CliMenu.Enums;

namespace CliMenu.Abstract.Interfaces.Navigation
{
    /// <summary>
    /// Interface for navigation functionality.
    /// </summary>
    public interface INavigable
    {
        /// <summary>
        /// Handles navigation in a given direction.
        /// </summary>
        /// <param name="direction">Direction to navigate.</param>
        void Navigation(Directions direction);
    }
}
