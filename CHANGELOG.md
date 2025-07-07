# ChangeLog

All future updates for CliMenu will be documented in this file

## [Unreleased] CliMenu BETA - Coming Soon :\)

## [0.2.1] CliMenu Core Architecture v3 - Jul 5, 2025
### Added:
- `BaseComponent` has two new behaviors: `FocusManager` and `LifeCycle`.
- You can now use `Extends<TComponent>` to embed an inner component in your classes and also use 
`ExtendsComponent<TComponent>` to embed an inner component in `BaseComponent` classes.
- There's a new empty interface `INoOp` for all no-op behaviors.

### Changed:
- Now all the `BaseComponent` events are separated into behaviors classes (`Displayer`, `InputHandler`, etc).
- Now the no-op implementation records are placed in separate files.
- The default behaviors in `BaseComponent` are now defined with `ComponentConfig`.

### Fixed: 
- The `BaseComponent` constructor now works properly.

### Removed:
- `IExecutable` and its derivatives.
- `BaseFocusableComponent`.


## [0.2.0] CliMenu Core Architecture v2 - Jul 4, 2025
### Added:
- New core architecture for CliMenu
- Abstract component classes: `BaseComponent`, `BaseFocusableComponent`, `Extends<TComponent>`
- Abstract behavior classes: `Displayer<TComponent>`, `Executable<TComponent>`, `InputHandler<TComponent>`
- Interfaces: `IDisplayer`, `IExecutable`, `IFocusable`, `IInputHandler`, `ILifeCycle`
- No-op implementation records: `NoExecutable`, `NoDisplay`, `NoInputHandler`

### Changed:
- None

### Fixed:
- None

### Removed:
- Old architecture

## [0.1.x] CliMenu Core Architecture v1 - May 24, 2025
### Notes:
- The 0.1.x updates aren't documented.