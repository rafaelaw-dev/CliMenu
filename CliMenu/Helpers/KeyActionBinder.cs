using CliMenu.Interfaces;

namespace CliMenu.Helpers;

/// <summary>
/// Represents a binding between a keyboard key and an action to be performed on a specific component.
/// </summary>
/// <typeparam name="TComponent">The type of the component that implements the <see cref="IComponent"/> 
/// interface and that the action will operate on.</typeparam>
/// <param name="Key">The keyboard key (<see cref="ConsoleKey"/>) that triggers the action.</param>
/// <param name="Action">The action (<see cref="Action{TComponent}"/>) to execute when the key is pressed.
/// This can be null to indicate no action is associated with the key.</param>
public record KeyActionBinder<TComponent>(ConsoleKey Key, Action<TComponent>? Action)
    where TComponent : IComponent;