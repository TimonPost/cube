namespace MatrixTransformations.Math
{
    public struct Vector
    {
        public float x, y, z;
            
        public float w { get; set; }
        
        public Vector(float x = 0, float y = 0, float z = 0, float w = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static Vector NullVector { get; } = new Vector(0, 0, 0, 1);
        
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w - v2.w);
        }

        public static Vector operator *(Vector v1, float value)
        {
            return new Vector(v1.x * value, v1.y * value, v1.z * value, v1.w * value);
        }

        public static float Dot(Vector vector1, Vector vector2)
        {
            return vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
        }

        public static Vector Normalize(Vector value)
        {
            float factor = (float)System.Math.Sqrt((value.x * value.x) + (value.y * value.y) + (value.z * value.z));
            factor = 1f / factor;
            return new Vector (value.x * factor, value.y * factor, value.z * factor);
        }

        public static Vector Transform(Vector vector, Matrix matrix)
        {
            return new Vector(
                vector.x * matrix[0,0] + vector.y * matrix[1,0] + vector.z * matrix[2,0] + vector.w * matrix[3,0],
                vector.x * matrix[0,1] + vector.y * matrix[1,1] + vector.z * matrix[2,1] + vector.w * matrix[3,1],
                vector.x * matrix[0,2] + vector.y * matrix[1,2] + vector.z * matrix[2,2] + vector.w * matrix[3,2],
                vector.x * matrix[0,3] + vector.y * matrix[1,3] + vector.z * matrix[2,3] + vector.w * matrix[3,3]);
        }

        public static Vector Cross(Vector vector1, Vector vector2)
        {
            var x = vector1.y * vector2.z - vector2.y * vector1.z;
            var y = -(vector1.x * vector2.z - vector2.x * vector1.z);
            var z = vector1.x * vector2.y - vector2.x * vector1.y;
            
            return new Vector(x, y, z);
        }
        
        public override string ToString()
        {
            return $"X: {x}, Y:{y}, Z: {z}, W: {w}";
        }
    }
}
