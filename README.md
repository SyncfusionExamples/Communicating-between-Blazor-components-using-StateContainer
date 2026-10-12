# Communicating Between Blazor Components Using StateContainer

## Overview

This sample demonstrates how Blazor components can communicate through a shared StateContainer service that maintains application state across multiple UI components. Rather than relying on direct component references or complex cascading parameter hierarchies, the sample uses a centralized state management approach to keep components synchronized when data changes.

The application is built as a Blazor project and illustrates a common pattern for sharing data between independent components. This approach helps improve maintainability, reduces coupling, and enables reusable components that react to shared state changes consistently throughout the application.

The implementation uses Syncfusion Blazor components within a state-driven architecture, allowing multiple components to consume and react to the same data source.

## Key Features

- Demonstrates component-to-component communication using a shared `SessionGlobals` StateContainer service.
- Injects the shared state service through Blazor dependency injection using `@inject SessionGlobals sessionGlobals`.
- Displays shared state values through the Syncfusion `SfTextBox` component using the `Value` property bound to `sessionGlobals.MainMessage`.
- Uses the Syncfusion `SfButton` component with the `IsToggle="true"` property to provide toggle-based user interaction.
- Handles button interactions through the `@onclick` event and the `onToggleClick` method.
- Updates shared application state using the `SessionGlobals.SetMessage()` method.
- Dynamically changes the button content between `"Play"` and `"Pause"` based on the current toggle state.
- Synchronizes UI updates across subscribed components through the `SessionGlobals.OnChange` event.
- Registers state-change notifications during component initialization using the `OnInitialized()` lifecycle method.
- Refreshes the component UI automatically by invoking `StateHasChanged` when the shared state changes.
- Implements `IDisposable` to unsubscribe from the `OnChange` event and prevent memory leaks when the component is destroyed.
- Demonstrates real-time state sharing between independent Blazor components without direct component references.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository to your local machine.
2. Open the solution file:

   `BlazorComponentUsingStateContainer.sln`

3. Restore all NuGet packages.
4. Build the solution.
5. If required, set `BlazorComponentUsingStateContainer` as the startup project.
6. Run the application using **Ctrl+F5**.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Navigate to the project directory.

```bash
cd Communicating-between-Blazor-components-using-StateContainer
dotnet restore
dotnet run
```

3. Open the URL displayed in the terminal after the application starts.

## Project Structure

`Pages/Index.razor` - Main sample page that demonstrates StateContainer-based communication, displays shared state using `SfTextBox`, updates shared state through `SessionGlobals.SetMessage()`, and listens for state changes through the `OnChange` event.

`Globals.cs` - Contains the `SessionGlobals` StateContainer implementation, including shared state properties, state update methods, and notification events used for component communication.

`appsettings.json` - Application configuration settings.

`appsettings.Development.json` - Development environment configuration settings.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- [Getting Started with .NET MAUI Blazor App](https://blazor.syncfusion.com/documentation/getting-started/maui-blazor-app)

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.