﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    /// <summary>
    /// This class for creating and working with Vector.
    /// </summary>
    /// <remarks>
    /// This class can add, subtract, multiply and divide.
    /// </remarks>
    public class Vector3
    {
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
        /// Calculates the length of a vector
        /// </summary>
        /// <param name="v1">A input vector</param>
        /// <returns>Returns the length of the vector</returns>
        public static double Length(Vector3 v1)
        {
            double l = Math.Sqrt((v1.x * v1.x) + (v1.y * v1.y) + (v1.z * v1.z));
            l = Math.Abs(l);
            return l;
        }
    }
}
