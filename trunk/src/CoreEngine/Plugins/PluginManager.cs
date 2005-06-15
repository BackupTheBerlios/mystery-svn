using System;
using System.Reflection;

using Engine.Core.Utility;


namespace Engine.Core.Plugin
{
    /// <summary>
    ///  A Plug-in manager which helps load and manage plug-ins
    /// </summary>
	public class PluginManager
	{
        /// <summary>
        ///  Loads the specified plug-in
        /// </summary>
        /// <param name="DllFile">What plugin should be loaded</param>
        /// <returns>The plug-in that was loaded</returns>
		public object LoadPlugin(string DllFile)
		{
			object Plug;

			try
			{
				string path = (Environment.CurrentDirectory + "\\Plugins\\" + DllFile);
				
				Assembly plugin = Assembly.LoadFile(path);

				LogManager.WriteLog("{0}", path);

				Type[] types = plugin.GetTypes();

				LogManager.DWriteLog("\t \t Plugin: {0}", types[0]);
				
				Plug = Activator.CreateInstance(types[0]);	
			}

			catch (System.Exception e)
			{
				LogManager.DWriteLog("\t \t Plugin Manager could not load Plugins: {0}", e);
				throw new System.Exception("Plugin Could not be Loaded : {0}", e);
			}

			return Plug;
		}
	}
}