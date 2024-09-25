using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

// ReSharper disable once CheckNamespace
public static class MyRenderModes
{
    /// <summary>
    ///     Interactive server render mode with prerendering disabled, so only rendered after client web socket is connected.
    /// </summary>
    public static IComponentRenderMode InteractiveServerWithoutPrerendering { get; } =
        new InteractiveServerRenderMode(prerender: false);

    // TODO Uncomment one of these to test different render modes in the app:

    // Test case 1 - RenderMode.InteractiveServer used in app
    public static IComponentRenderMode AppRenderMode { get; } = RenderMode.InteractiveServer;

    // Test case 2 - MyRenderModes.InteractiveServerWithoutPrerendering used in app
    // public static IComponentRenderMode AppRenderMode { get; } = InteractiveServerWithoutPrerendering;
}
