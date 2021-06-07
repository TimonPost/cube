using System.Collections.Generic;
using MatrixTransformations.Math;

namespace MatrixTransformations.World
{
    public class Camera
    {
        public Matrix GetMatrix()
        {
            return Matrix.CreateLookAt(Position, LookAt, UpVector);
        }

        public Vector UpVector = new Vector(0, 1, 0);

        public Vector LookAt { get; set; } = new Vector(0,0,0);
        
        public Vector Position { get; set; } = new Vector(0, 0, 3);

        public void Reset()
        {
            UpVector =  new Vector(0, 1, 0);
            LookAt = new Vector(0, 0, 0);
            Position = new Vector(0, 0, 3);
        }
    }
}
