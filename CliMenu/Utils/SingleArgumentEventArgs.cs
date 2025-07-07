namespace CliMenu.Utils;

/// <summary>
/// Represents event data containing a single argument of type <typeparamref name="T"/>.
/// Inherits from <see cref="EventArgs"/> to be used in event handlers.
/// </summary>
/// <typeparam name="T">The type of the argument carried by the event.</typeparam>
/// <param name="argument">The argument value to be passed with the event.</param>
public class SingleArgumentEventArgs<T>(T argument) : EventArgs
{
    /// <summary>
    /// Gets or sets the argument value associated with the event.
    /// </summary>
    public T Argument { get; set; } = argument;
}