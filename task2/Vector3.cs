using System;

namespace task2
{
    public class Vector3
    {
        float x;
        float y;
        float z;
        public Vector3()                                        //Конструктор по умолчанию
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public static Vector3 operator +(Vector3 v1, Vector3 v2) //перегрузка операции сложения
        {
            v1.x += v2.x;
            v1.y += v2.y;
            v1.z += v2.z;
            return v1;
        }
        public static Vector3 operator -(Vector3 v1, Vector3 v2)//перегрузка операции вычитания
        {
            v1.x -= v2.x;
            v1.y -= v2.y;
            v1.z -= v2.z;
            return v1;
        }
        public static Vector3 operator *(Vector3 v1, float i)//умножение на скаляр (увеличение длины вектора)
        {
            v1.x *= i;
            v1.y *= i;
            v1.z *= i;
            return v1;
        }
        public static Vector3 operator /(Vector3 v1, float i)//деление на скаляр (уменьшение длины вектора)
        {
            v1.x *= i;
            v1.y *= i;
            v1.z *= i;
            return v1;
        }
    }
}
