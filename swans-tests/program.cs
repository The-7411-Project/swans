using System;
using System.Collections.Generic;
using System.Text;

//OpenTK handles C# OpenGL for Swans.
using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.Common;
using OpenTK.Graphics.OpenGL4;


namespace Swans
{
    class Main : GameWindow
{
    /// <summary>
    /// widthxheight for window size, title is the title of the window
    /// </summary>
    public Main(int width, int height, string title)
        : base(GameWindowSettings.Default, new NativeWindowSettings()
        {
            Title = title,
            Size = new Vector2i(width, height),
            WindowBorder = WindowBorder.Resizable,
            StartVisible = false,
            StartFocused = true,
            WindowState = WindowState.Normal,
            API = ContextAPI.OpenGL,
            Profile = ContextProfile.Core,
            APIVersion = new Version(3, 3)
        })
    {
        CenterWindow();
    }
}
