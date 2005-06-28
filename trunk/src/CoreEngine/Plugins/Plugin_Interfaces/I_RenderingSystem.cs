using System;

namespace Engine.Core.Plugin
{
    /// <summary>
    /// An interface which a RenderingSystem plug-in must abide by to be loaded
    /// </summary>
	public interface I_RenderingSystem
	{
        /// <summary>
        ///  Clears the window to a specified color
        /// </summary>
        /// <param name="RGB">The RGB value to clear the window to</param>
        /// <returns>If it was successful in clearing the winddow</returns>
		bool ClearScreen(int RGB);

        bool Setup();
	}
}
