using System;

namespace Engine.Core.Plugin
{
	public interface I_PlatformManager
	{
		bool CreateWindow(string caption, string PathToIcon, int x, int y, int bits, bool fullscreen);

		IntPtr GetWindow();

		bool DestroyWindow();
	}
}