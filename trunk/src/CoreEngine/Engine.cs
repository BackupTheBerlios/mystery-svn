using System;
using Engine.Core.Utility;
using Engine.Core.Plugin;

namespace Engine.Core
{
    /// <summary>
    ///  The Core Engine class by which almost all functionality is accessed
    /// </summary>
	public class MEngine
	{
		/// <summary>
		///  The Renderer Plugin
		/// </summary>
		public I_RenderingSystem Renderer;

        /// <summary>
        /// The Platform Manager plugin
        /// </summary>
        public I_PlatformManager Platmgr;

        /// <summary>
        ///  The plug-in manager
        /// </summary>
        public PluginManager PlugMan;

        /// <summary>
        ///  Initialization flags pertaining to the start-up of the engine
        /// </summary>
        public enum Init_Flags
        {
            /// <summary>
            /// A flag letting the engine know that graphics should be initialized
            /// </summary>
            Graphics,

            /// <summary>
            /// A flag letting the engine know that the sound system should be initialized
            /// </summary>
            Sound
        }

        /// <summary>
        ///  Initializes the Mystery Engine
        /// </summary>
        /// <param name="init">Init_Flags telling the engine what should be initialized</param>
        /// <returns>A bool value containing whether or not the initailization succeeded</returns>
        public bool Initialize_Engine(Init_Flags init)
        {
            LogManager.DWriteLog("Intializing Mystery Engine \n");

            LogManager.DWriteLog("******************************");

            Initialize_PluginSystem();

            LogManager.DWriteLog("\n Loading Plugins ... \n");

            switch (init)
            {
                default:
                    throw new Exception("Please use the Proper Initialization Flags");
                case Init_Flags.Graphics:
                    Initialize_PlatformManager();
                    Initialize_GraphicsSystem();
                    break;
            }


            LogManager.DWriteLog("\n Plugins Loaded \n");

            LogManager.DWriteLog("******************************");

            LogManager.DWriteLog("\nMystery Engine successfully initialized! \n");

            return true;
        }

		/// <summary>
		/// Intializes the Plugin System
		/// </summary>
		private void Initialize_PluginSystem()
		{
            try
            {
                LogManager.DWriteLog("\nInitializing Plugin Manager \n");
                PlugMan = new PluginManager();
            }
            catch (Exception e)
            {
                throw new Exception("Plugin manager could not ne initialized: {0}", e);
            }

            LogManager.DWriteLog("Plugin Manager initailized");

		}

        /// <summary>
        ///  Initializes the Graphics subsystem from a plug-in
        /// </summary>
        private void Initialize_GraphicsSystem()
        {
            Renderer = (I_RenderingSystem)PlugMan.LoadPlugin("OGL_Renderer.dll");
        }

        /// <summary>
        ///  Initializes the PlatformManager from a plug-in
        /// </summary>
        private void Initialize_PlatformManager()
        {
            Platmgr = (I_PlatformManager)PlugMan.LoadPlugin("SDL_PlatformManager.dll");
        }
	}
}