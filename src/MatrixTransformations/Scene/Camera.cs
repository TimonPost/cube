using System;
using System.Collections.Generic;
using MatrixTransformations.MathCustom;

namespace MatrixTransformations.World
{
    public class Camera
    {
        public Matrix GetMatrix()
        {
            return GetCameraMatrix();
            //return Matrix.CreateLookAt(Position, LookAt, UpVector);
        }

        public Vector UpVector = new Vector(0, 1, 0);

        public Vector LookAt { get; set; } = new Vector(0,0,0);
        
        public Vector Position { get; set; } = new Vector(0, 0, 3);


        public float D = 800;
        public float R = 10;
        public float THETA = -100;
        public float PHI = -10;

        public Matrix GetCameraMatrix()
        {
            var camera = Matrix.Identity();
            camera[0, 3] = R * (float)System.Math.Sin(PHI) * (float)System.Math.Cos(THETA);
            camera[1, 3] = R * (float)System.Math.Sin(PHI) * (float)System.Math.Sin(THETA);
            camera[2, 3] = R * (float)System.Math.Cos(PHI);
            camera[3, 3] = 1;

            var rotateZ = Matrix.RotateZ(THETA + (float) ToRadians(90));
            var rotateX = Matrix.RotateX(PHI);

            var result = rotateX * rotateZ * camera;

            // var inverse = new Matrix(
            //     (float)-Math.Sin(THETA), (float)Math.Cos(THETA), 0.0f, 0.0f,
            //     (float)(-Math.Cos(THETA) * Math.Cos(PHI)), (float)(-Math.Cos(PHI) * Math.Sin(THETA)), (float)Math.Sin(PHI), 0.0f,
            //     (float)(Math.Cos(THETA) * Math.Sin(PHI)), (float)(Math.Sin(THETA) * Math.Sin(PHI)), (float)Math.Cos(PHI), -R,
            //     0.0f, 0.0f, 0.0f, 1.0f
            // );

            return result.Invert();


           
            
        }

        public static double ToRadians(double val)
        {
            return (System.Math.PI / 180) * val;
        }

        public void Reset()
        {
            UpVector =  new Vector(0, 1, 0);
            LookAt = new Vector(0, 0, 0);
            Position = new Vector(0, 0, 3);
        }
    }
}
