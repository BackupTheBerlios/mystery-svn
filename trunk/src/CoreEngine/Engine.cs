using System;
using Engine.Core.Utility;
using Engine.Core.Plugin;

namespace Engine.Core
{
	public class MEngine
	{
		/// <summary>
		///  The Renderer Plugin
		/// </summary>
		public I_RenderingSystem Renderer;

		/// <summary>
		/// Intializes the Core Engine
		/// </summary>
		public void Initialize_Engine()
		{
			LogManager.DWriteLog("Intializing Mystery Engine \n");

			LogManager.DWriteLog("******************************");

			#region Initialize_Plugins

			PluginManager PlugMan;
			
			PlugMan = new PluginManager();

			try
			{
				LogManager.DWriteLog("\n Loading Plugins ... \n");
				Renderer = (I_RenderingSystem)PlugMan.LoadPlugin("OGL_Renderer.dll");
			}

			catch (System.Exception e)
			{
				LogManager.DWriteLog("\t \t Plugin Manager could not load Plugins: {0}", e);
				throw new System.Exception("\t \t Plugin Manager could not load Plugins: {0}", e);
			}

			LogManager.DWriteLog("\n Plugins Loaded \n");

			#endregion Initialize_Plugins

			LogManager.DWriteLog("******************************");

			LogManager.DWriteLog("\nMystery Engine successfully initialized! \n");
		}
	}
}