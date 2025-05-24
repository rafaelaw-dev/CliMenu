namespace CliMenu.Abstract.Interfaces.Navigation
{
    /// <summary>
    /// Interface for navigable columns, allowing selection of a specific column.
    /// </summary>
    public interface INavigableColumn : INavigable
    {
        /// <summary>
        /// Currently selected column index.
        /// </summary>
        int SelectedCollumn { get; set; }
    }
}