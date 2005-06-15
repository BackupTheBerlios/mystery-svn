using System;

namespace Engine.Core.Plugin
{
    /// <summary>
    ///  An interface which a PlatformManager plug-in must abide by to be loaded
    /// </summary>
	public interface I_PlatformManager
	{
        /// <summary>
        ///  Creates a new window
        /// </summary>
        /// <param name="WindowCaption">The string holding the title of the window</param>
        /// <param name="Width">The width of the window</param>
        /// <param name="Height">The height of the window</param>
        /// <param name="BitsPerPixel">The number of color bits per pixel in the window</param>
        /// <param name="FullScreen">A bool value containing wheter or not the window should be fullscreen</param>
        /// <returns>If it was successful</returns>
        bool CreateWindow(string WindowCaption, int Width, int Height, int BitsPerPixel, bool FullScreen);

        /// <summary>
        ///  Gets the window
        /// </summary>
        /// <returns>An Intptr representing the window</returns>
	    IntPtr GetWindow();

        /// <summary>
        ///  Destroys the window
        /// </summary>
        /// <returns>If it was successful in destroying the window</returns>
		bool DestroyWindow();
	}
}