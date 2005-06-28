using System;
using TS = Tao.Sdl.Sdl;
using Engine.Core.Plugin;

namespace SDL_PlatformManager
{
	public class SDL_WindowManager : I_PlatformManager
	{

        public bool quit = false;

        /// <summary>
        /// A Intptr containing the current window
        /// </summary>
        private IntPtr Window;

        public bool Setup()
        {
            try
            {
                TS.SDL_Init(TS.SDL_INIT_VIDEO | TS.SDL_INIT_TIMER);
            }
            catch (System.Exception e)
            {
                throw new System.Exception("SDL could not be initialized: {0}", e);
            }
            return true;

        }

        /// <summary>
        ///  Creates a new window
        /// </summary>
        /// <param name="WindowCaption">The string holding the title of the window</param>
        /// <param name="BmpIcon">The Bitmap icon's filename to be loaded by the window</param>
        /// <param name="Width">The width of the window</param>
        /// <param name="Height">The height of the window</param>
        /// <param name="BitsPerPixel">The number of color bits per pixel in the window</param>
        /// <param name="FullScreen">A bool value containing wheter or not the window should be fullscreen</param>
        /// <returns>If it was successful</returns>
		public bool CreateWindow(string WindowCaption, string BmpIcon, int Width, int Height, int BitsPerPixel, bool FullScreen, bool OpenGl)
		{
            int flags = TS.SDL_ANYFORMAT;

            if (OpenGl == true)
            {
                flags |= TS.SDL_HWSURFACE | TS.SDL_OPENGL | TS.SDL_GL_DOUBLEBUFFER;
            }
            else
            {
                flags |= TS.SDL_RESIZABLE;
            }

			if (FullScreen == true)
			{
				flags |= TS.SDL_FULLSCREEN;
			}

            try
            {
                string icopath = Environment.CurrentDirectory + "\\" + BmpIcon;

                Console.WriteLine("{0}", icopath);

                Window = TS.SDL_SetVideoMode(Width, Height, BitsPerPixel, flags);

                if (Window == IntPtr.Zero)
                {
                    Console.WriteLine("Window Could not be created");
                }

                IntPtr ico = TS.SDL_LoadBMP(icopath);

                TS.SDL_WM_SetIcon(ico, null);

                TS.SDL_WM_SetCaption(WindowCaption, null);

                //TS.SDL_WM_GrabInput(0);

                return true;
            }

            catch (Exception e)
            {
                throw new Exception("Window could not be created: {0}", e);
            }

            
		}

        public void GlSwapBuffers()
        {
            TS.SDL_GL_SwapBuffers();
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
