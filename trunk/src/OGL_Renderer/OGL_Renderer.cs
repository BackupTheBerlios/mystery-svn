using System;
using Engine.Core.Plugin;

namespace OGL_Renderer
{
	public class OpenGL_Renderer : I_RenderingSystem
	{
		public bool ClearScreen(int RGB)
		{
			try
			{
				//OGL_ClearScreen
			}
			catch (System.Exception e)
			{
				throw new System.Exception("{0}", e);
			}
			finally
			{
				RGB = 0;
			}
			return true;
		}
	}
}
