namespace CliMenu.Source.Base;

internal abstract class LifeCycle
{
    public bool IsActive { get; protected set; }

    protected virtual void Enable() => IsActive = true;
    protected virtual void Update() { }
    protected virtual void Disable() => IsActive = false;
}