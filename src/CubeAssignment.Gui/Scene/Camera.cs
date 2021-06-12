namespace CubeAssignment.Gui.Scene
{
    public class Camera
    {
        public Matrix GetMatrix()
        {
            Matrix camera = Matrix.Identity();
            camera[0, 3] = R * (float) System.Math.Sin(PHI) * (float) System.Math.Cos(THETA);
            camera[1, 3] = R * (float) System.Math.Sin(PHI) * (float) System.Math.Sin(THETA);
            camera[2, 3] = R * (float) System.Math.Cos(PHI);
            camera[3, 3] = 1;

            Matrix rotateZ = Matrix.RotateZ(THETA + (float) Utils.DegreesToRadians(90));
            Matrix rotateX = Matrix.RotateX(PHI);
            Matrix result = rotateX * rotateZ * camera;

            return result.Invert();
        }

        public Vector Position { get; set; } = new Vector(0, 0, 3);

        public float D = 800;
        public float R = 10;
        public float THETA = -100;
        public float PHI = -10;

        public void Reset()
        {
            Position = new Vector(0, 0, 3);
        }
    }
}