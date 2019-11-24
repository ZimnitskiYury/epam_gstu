using System;

namespace task2
{
    /// <summary>
    /// This class for creating and working with Vector.
    /// </summary>
    public class Vector3
    {
        const float eps= 0.01f;
        private float x;
        private float y;
        private float z;
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        /// <summary>
        /// Constructor with one float param.
        /// </summary>
        /// <param name="k">A float number</param>
        public Vector3(float k)
        {
            x = k;
            y = k;
            z = k;
        }
        /// <summary>
        /// Constructor with three float param.
        /// </summary>
        /// <param name="a">A float number for X.</param>
        /// <param name="b">A float number for Y.</param>
        /// <param name="c">A float number for Z.</param>
        public Vector3(float a, float b, float c)
        {
            x = a;
            y = b;
            z = c;
        }
        /// <summary>
        /// Adds two vectors and returns the result.
        /// </summary>
        /// <param name="v1">A first input vector</param>
        /// <param name="v2">A second input vector</param>
        /// <returns>The new object with sum of two vectors.</returns>
        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }
        /// <summary>
        /// Subtracts an object from another and returns the result.
        /// </summary>
        /// <param name="v1">A first input vector</param>
        /// <param name="v2">A second input vector</param>
        /// <returns>The new object with difference between two vectors</returns>
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }
        /// <summary>
        /// Negates an input vector.
        /// </summary>
        /// <param name="v1">A input Vector</param>
        /// <returns>The new negated vector</returns>
        public static Vector3 operator -(Vector3 v1)
        {
            return new Vector3(-1 * v1.x, -1 * v1.y, -1 * v1.z);
        }
        /// <summary>
        /// Multiplies a vector by a scalar float number
        /// </summary>
        /// <remarks>Increase the length of the vector</remarks>
        /// <param name="v1">A input vector</param>
        /// <param name="i">A scalar float number</param>
        /// <returns>The new object with result</returns>
        public static Vector3 operator *(Vector3 v1, float i)
        {
            return new Vector3(v1.x * i, v1.y * i, v1.z * i);
        }
        /// <summary>
        /// Multiplies a two vectors
        /// </summary>
        /// <param name="v1">A first input vector</param>
        /// <param name="v2">A second input vector</param>
        /// <returns>The new object with result</returns>
        public static Vector3 operator *(Vector3 v1, Vector3 v2)
        {
            float vx = v1.y * v2.z - v1.z * v2.y;
            float vy = v1.z * v2.x - v1.x * v2.z;
            float vz = v1.x * v2.y - v1.y * v2.x;
            return new Vector3(vx, vy, vz);
        }
        /// <summary>
        /// Divides a vector by a scalar float number
        /// </summary>
        /// <remarks>Decrease the length of the vector</remarks>
        /// <param name="v1">A input vector</param>
        /// <param name="i">A scalar float number</param>
        /// <returns>The new object with result</returns>
        public static Vector3 operator /(Vector3 v1, float i)
        {
            return new Vector3(v1.x / i, v1.y / i, v1.z / i);
        }
        /// <summary>
        /// Сompares a two vectors for equality
        /// </summary>
        /// <param name="v1">A first input vector</param>
        /// <param name="v2">A second input vector</param>
        /// <returns>Returns true if equal</returns>
        public static bool operator ==(Vector3 v1, Vector3 v2)
        {
            if (Math.Abs(v1.x-v2.x)<eps)
            {
                if (Math.Abs(v1.y - v2.y) < eps)
                {
                    if (Math.Abs(v1.z - v2.z) < eps)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Сompares a two vectors for non-equality
        /// </summary>
        /// <param name="v1">A first input vector</param>
        /// <param name="v2">A second input vector</param>
        /// <returns>Returns true if non-equal</returns>
        public static bool operator !=(Vector3 v1, Vector3 v2)
        {
            return !(v1 == v2);
        }
        /// <summary>
        /// Calculates the length of a vector
        /// </summary>
        /// <param name="v1">A input vector</param>
        /// <returns>Returns the length of the vector</returns>
        public static double GetLength(Vector3 v1)
        {
            double l = Math.Sqrt((v1.x * v1.x) + (v1.y * v1.y) + (v1.z * v1.z));
            return Math.Abs(l);
        }
        /// <summary>
        /// Calculates the length of a vector
        /// </summary>
        /// <returns>Returns the length of the vector</returns>
        public double GetLength()
        {
            double l = Math.Sqrt((x * x) + (y * y) + (z * z));
            return Math.Abs(l);
        }
        /// <summary>
        /// Returns the dot product of two vectors
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>The dot product of two vectors</returns>
        public static float GetScalar(Vector3 v1, Vector3 v2)
        {
            float scalarX = v1.x + v2.x;
            float scalarY = v1.y + v2.y;
            float scalarZ = v1.z + v2.z;
            return scalarX + scalarY + scalarZ;
        }
    }
}
