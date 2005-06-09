#region Vector3Manipulation

// Load The System Libraries
using System;

namespace Engine.Core.Math
{
	/// <summary>
	///  Static class used for manipulating three-diminsional vectors
	/// </summary>
	static public class Vector3Manipulation
	{
		/// <summary>
		///  Returns a Vector3 struct with all values set to zero
		/// </summary>
		/// <returns>A zeroed Vector3 struct</returns>
		static public Vector3 Zero()
		{
			return new Vector3( 0.0, 0.0, 0.0);
		}

		/// <summary>
		/// Finds the magnitude of a Vector3 struct
		/// </summary>
		/// <param name="vec1">The Vector3 struct which is used as input</param>
		/// <returns>A double which has the calculated magnitude of the Vector3 struct in it</returns>
		static public double FindMagnitude(Vector3 vec1)
		{
			return System.Math.Sqrt(((vec1.x * vec1.x) + (vec1.y * vec1.y) + (vec1.z * vec1.z))); 
		}

		/// <summary>
		///  Finds the cross-product of two Vector3 structs
		/// </summary>
		/// <param name="a">The first Vector3 struct used for input</param>
		/// <param name="b">The second Vector3 struct used for input</param>
		/// <returns>A Vector3 struct that holds the cross-product of the two inputted Vector3 structs</returns>
		static public Vector3 CrossProduct(Vector3 a, Vector3 b)
		{
			return new Vector3((a.y * b.z) - (a.z * b.y), 
							   (a.z * b.x) - (a.x * b.z),
							   (a.x * b.y) - (a.y * b.x));
		}

		/// <summary>
		///  Finds the distance between the two Vector3 structs
		/// </summary>
		/// <param name="a">The first Vector3 struct used for input</param>
		/// <param name="b">The second Vector3 struct used for input</param>
		/// <returns>A double containing the distance between the to inputted Vector3 structs</returns>
		static public double Distance(Vector3 a, Vector3 b)
		{
			return (((a.x - b.x) * (a.x - b.x)) + ((a.y - b.y) * (a.y - b.y)) + ((a.z - b.z) * (a.z - b.z)));
		}
	}
}
#endregion Vector3Manipulation