namespace CliMenu.Abstract.Interfaces.Navigation
{
    /// <summary>
    /// Interface for navigable rows, allowing selection of a specific row.
    /// </summary>
    public interface INavigableRow : INavigable
    {
        /// <summary>
        /// Currently selected row index.
        /// </summary>
        int SelectedRow { get; set; }
    }
}