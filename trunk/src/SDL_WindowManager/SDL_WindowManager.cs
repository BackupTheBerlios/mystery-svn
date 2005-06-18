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
        ///  Creates a new window
        /// </summary>
        /// <param name="WindowCaption">The string holding the title of the window</param>
        /// <param name="Width">The width of the window</param>
        /// <param name="Height">The height of the window</param>
        /// <param name="BitsPerPixel">The number of color bits per pixel in the window</param>
        /// <param name="FullScreen">A bool value containing wheter or not the window should be fullscreen</param>
        /// <returns>If it was successful</returns>
		public bool CreateWindow(string WindowCaption, int Width, int Height, int BitsPerPixel, bool FullScreen)
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

                TS.SDL_WM_SetCaption(WindowCaption, "");

                TS.SDL_WM_GrabInput(0);

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
