//Load the assemblies
using System;
using System.IO;

namespace Engine.Core.Utility
{
	/// <summary>
	///  hm
	/// </summary>
	public sealed class Log : IDisposable
	{
		#region Fields
		
		/// <summary>
		///File stream used for opening the log file
		/// </summary>
		
		private FileStream log;


		/// <summary>
		///Writer used for writing to the log file.
		/// </summary>
		
		private StreamWriter writer;


		/// <summary>
		///A string that represents the file to write to.
		/// </summary>
		

		private string filename;

		#endregion Fields
		
		#region Constructor
		
		/// <summary>
		///     Constructor.  Creates a log file that also logs debug output.
		/// </summary>
		/// <param name="fileName">Name of the log file to open.</param>
		
		public Log(string fileName)
		{
			filename = fileName;
			log = File.Open(filename, FileMode.Create);
			log.Close();
			
			try
			{
				log = File.Open(filename, FileMode.Open);
			}
			catch(System.Exception e)
			{
				Console.WriteLine("File: {0} could not be opened", filename);
				Console.WriteLine("{0}", e);
			}

			// get a stream writer using the file stream
			writer = new StreamWriter(log);
			writer.BaseStream.Seek(0, SeekOrigin.End);
			
		}
		
		#endregion Constructor
		
		#region Functions
		
		/// <summary>
		///     Write a message to the log.
		/// </summary>
        /// <param name="DebugOutput">should it write the message to the Command Line</param>
		/// <param name="message">Message to write, which can include string formatting tokens.</param>
		/// <param name="substitutions">
		///     When message includes string formatting tokens, these are the values to
		///     inject into the formatted string.
		/// </param>
		
		public void Write(bool DebugOutput, string message, params object[] substitutions)
		{
			
			if(writer.BaseStream != null)
			{
				// construct the log message
				if (substitutions != null && substitutions.Length > 0) {
					message = string.Format(message, substitutions);
				}

				if (DebugOutput == true)
				{
					Console.WriteLine(message, substitutions);
				}

				// prepend the current time to the message
				// message = string.Format("[{0}] {1}", DateTime.Now.ToString("hh:mm:ss"), message);
				
				// write the message and flush the buffer
				writer.WriteLine(message);
				writer.Flush();
			}
			
			
		}

		#endregion Functions
		
		#region IDisposable_Members
		
        /// <summary>
        ///  Closes the log writer
        /// </summary>
		public void Dispose()
		{
			writer.Close();
			log.Close();
		}
		
		#endregion IDisposable_Members
	}
}

