using System;
using TS = Tao.Sdl.Sdl;
using Engine.Core.Plugin;

namespace SDL_PlatformManager
{
	public class SDL_WindowManager : I_PlatformManager
	{
        /// <summary>
        /// A Intptr containing the current window
        /// </summary>
        private IntPtr Window;

        /// <summary>
		/// Sets the video mode of a fullscreen application
		/// </summary>
		/// <param name="Width">screen width</param>
		/// <param name="Height">screen height</param>
		/// <param name="BitsPerPixel">bits per pixel</param>
		/// <param name="FullScreen">do you want the window to be fullscreen</param>
		/// <returns>A bool</returns>
		public bool CreateWindow(int Width, int Height, int BitsPerPixel, bool FullScreen)
		{
            bool quit = false;

			int flags = (TS.SDL_GL_DOUBLEBUFFER|TS.SDL_HWSURFACE|TS.SDL_OPENGL|TS.SDL_ANYFORMAT);
			
			if (FullScreen)
			{
				flags |= TS.SDL_FULLSCREEN;
			}

            try
            {
                Window = TS.SDL_SetVideoMode(Width, Height, BitsPerPixel, flags);

                if (Window == IntPtr.Zero)
                {
                    Console.WriteLine("Window Could not be created");
                }

                while (quit == false)
                {
                    TS.SDL_GL_SwapBuffers();
                }
                return true;
            }

            catch (Exception e)
            {
                throw new Exception("Window could not be created: {0}", e);
            }

            
		}

		public IntPtr GetWindow()
		{
            return Window;
		}

		public bool DestroyWindow()
		{
            TS.SDL_Quit();
			return true;
		}


	}
}
