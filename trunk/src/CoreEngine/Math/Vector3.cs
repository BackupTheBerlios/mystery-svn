#region Vector3

//Load The Main System Libraries
using System;

namespace Engine.Core.Math
{
	/// <summary>
	///  A simple, 3D vector struct
	/// </summary>
	public struct Vector3
	{
		/// <summary>
		///  Create three doubles to store the three
		///  values of the three-diminsional vector
		/// </summary>
		public double x, y, z;

		public Vector3(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static Vector3 operator +(Vector3 vec1, Vector3 vec2)
		{
			return new Vector3(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z); 
		}

		public static Vector3 operator -(Vector3 vec1, Vector3 vec2)
		{
			return new Vector3(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z); 
		}

		public static Vector3 operator -(Vector3 vec1) 
		{
			return new Vector3(-vec1.x, -vec1.y, -vec1.z); 
		}

		public static Vector3 operator *(Vector3 vec1, double a)
		{
			return new Vector3(vec1.x * a, vec1.y * a, vec1.z * a); 
		}

		public static Vector3 operator /(Vector3 vec1, double a)
		{
			return new Vector3(vec1.x / a, vec1.y / a, vec1.z / a); 
		}
	}
	
}
#endregion Vector3