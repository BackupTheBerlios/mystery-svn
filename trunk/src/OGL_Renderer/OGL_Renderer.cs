using System;
using Tao.OpenGl;
using Engine.Core.Plugin;

namespace OGL_Renderer
{
	public class OpenGL_Renderer : I_RenderingSystem
	{
		public bool ClearScreen(int RGB)
		{
			try
			{
               Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
					Gl.glBegin(Gl.GL_TRIANGLES);
					Gl.glVertex3f(0.0f, 1.0f, 0.0f);// Top
					Gl.glVertex3f(-1.0f, -1.0f, 0.0f);// Bottom Left
					Gl.glVertex3f(1.0f, -1.0f, 0.0f);// Bottom Right
					Gl.glEnd();                           // Done Drawing The Quad
			}
			catch (System.Exception e)
			{
				throw new System.Exception("{0}", e);
			}
			return true;
		}

        public bool Setup()
        {
            Gl.glShadeModel(Gl.GL_SMOOTH);                                      // Enable Smooth Shading
            Gl.glClearColor(0, 0, 1.0f, 0.5f);                                     // Black Background
            Gl.glClearDepth(1);                                                 // Depth Buffer Setup
            Gl.glEnable(Gl.GL_DEPTH_TEST);                                      // Enables Depth Testing
            Gl.glDepthFunc(Gl.GL_LEQUAL);                                       // The Type Of Depth Testing To Do
            Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, Gl.GL_NICEST);         // Really Nice Perspective Calculations
            return true;
        }
	}
}
