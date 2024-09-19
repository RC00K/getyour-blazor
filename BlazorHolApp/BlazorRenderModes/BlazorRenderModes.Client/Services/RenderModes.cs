namespace BlazorRenderModes.Client.Services;

public enum RenderMode
{
    Unknown,
    ServerStatic,
    ServerStaticStreaming,
    ServerInteractive,
    WebAssemblyInteractive
}

public static class RenderModeFlagsExtensions
{
    public static bool IsServer(this RenderMode modes)
    {
        return modes.ToString().Contains("Server");
    }

    public static bool IsWebAssembly(this RenderMode modes)
    {
        return modes == RenderMode.WebAssemblyInteractive;
    }

    public static bool IsInteractive(this RenderMode modes)
    {
        return modes.ToString().Contains("Interactive");
    }

    public static bool IsStatic(this RenderMode modes)
    {
        return modes == RenderMode.ServerStaticStreaming;
    }
}