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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The X value of a Vector3</param>
        /// <param name="y">The X value of a Vector3</param>
        /// <param name="z">The X value of a Vector3</param>
		public Vector3(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

        /// <summary>
        ///  Adds the two Vector3s together
        /// </summary>
        /// <param name="vec1">The first Vector3</param>
        /// <param name="vec2">The second Vector3</param>
        /// <returns></returns>
		public static Vector3 operator +(Vector3 vec1, Vector3 vec2)
		{
			return new Vector3(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z); 
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vec1"></param>
        /// <param name="vec2"></param>
        /// <returns></returns>
		public static Vector3 operator -(Vector3 vec1, Vector3 vec2)
		{
			return new Vector3(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z); 
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vec1"></param>
        /// <returns></returns>
		public static Vector3 operator -(Vector3 vec1) 
		{
			return new Vector3(-vec1.x, -vec1.y, -vec1.z); 
		}

        /// <summary>
        ///  Multiplies a Vector3 by a certain value
        /// </summary>
        /// <param name="vec1">The Vector3</param>
        /// <param name="a">Single value to multiply the Vector3 by</param>
        /// <returns></returns>
		public static Vector3 operator *(Vector3 vec1, double a)
		{
			return new Vector3(vec1.x * a, vec1.y * a, vec1.z * a); 
		}

        /// <summary>
        ///  Divides a Vector3 by a certain value
        /// </summary>
        /// <param name="vec1">The Vector3</param>
        /// <param name="a">Single value to divide the Vector3 by</param>
        /// <returns></returns>
		public static Vector3 operator /(Vector3 vec1, double a)
		{
			return new Vector3(vec1.x / a, vec1.y / a, vec1.z / a); 
		}
	}
	
}
#endregion Vector3