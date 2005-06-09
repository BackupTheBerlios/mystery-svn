//Load The Utility Classes
using Engine.Core.Utility;

namespace Engine.Core.Utility
{
	/// <summary>
	/// This is the LogManager, it has two functions which are static. 
	/// You can not create a new instance of a LogManager. You also may 
	/// not have another class derive from the LogManager. All the Logmanager 
	/// does is provide a static interface to the Log object. The first 
	/// function is very similar the the second one. The first 
	/// function writes a line to the Log. The second function does the 
	/// same thing, but it also writes the line to The Debug Output. 
	/// </summary>
	public sealed class LogManager
	{

		#region Singleton implementation
		
		/// <summary>
		/// Singleton instance of this class.
		/// </summary>
		private static LogManager instance;
		
		/// <summary> 
		/// Internal constructor.  This class cannot be instantiated externally.
		/// </summary>
		internal LogManager() {
			if (instance == null) {
				instance = this;
			}
		}
		
		/// <summary>
		/// Gets the singleton instance of this class.
		/// </summary>
		public static LogManager Instance {
			get {
				return instance;
			}
		}
		
		#endregion Singleton implementation

		#region Fields

		/// <summary>
		/// Create an static instance of the LogManager so only one Log is created
		/// </summary>
		static LogManager logman = new LogManager();
		/// <summary>
		/// Create a new log object
		/// </summary>
		private Engine.Core.Utility.Log dlog = new Log("MysteryEngine.txt");

		#endregion Fields

		#region Functions
		
		///<summary>
		///	A Static Method Which Writes to a Log
		///</summary>
		/// <param name="message">
		/// A string that is printed to the log
		/// </param>
		/// <param name="substitiutions">
		/// Things to substitute into the message such as variables
		/// </param>
		static public void WriteLog(string message, params object[] substitutions)
		{
			logman.dlog.Write(false, message, substitutions);
		}
		///<summary>
		///	A Static Method Which Writes to a Log and Prints the 
		/// messages to the Debug Output.
		///</summary>
		/// <param name="message">
		/// A string that is printed to the log
		/// </param>
		/// <param name="substitiutions">
		/// Things to substitute into the message such as variables
		/// </param>
		static public void DWriteLog(string message, params object[] substitutions)
		{
			logman.dlog.Write(true, message, substitutions);
		}

		#endregion Functions

	}
}
