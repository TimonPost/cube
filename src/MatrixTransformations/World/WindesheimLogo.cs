using System.Collections.Generic;
using System.Drawing;
using MatrixTransformations.Math;

namespace MatrixTransformations
{
    public class WindesheimLogo
    {
        public Color Color = System.Drawing.Color.Orange;

        public readonly IReadOnlyList<Vector> Vertexbuffer = new List<Vector>
        {
            new Vector(-0.482961f,  -0.211180f, 0.052569f),
            new Vector(-0.236975f,   0.060935f, 0.052569f),
            new Vector(-0.457712f,   0.299137f, 0.052569f),
            new Vector(-0.148784f,   0.360626f, 0.052569f),
            new Vector(0.447550f,    0.353084f, 0.052569f),
            new Vector(0.089222f,    0.377968f, 0.052569f),
            new Vector(0.189356f,   -0.142691f, 0.052569f),
            new Vector(0.712750f,    0.297276f, 0.052569f),
            new Vector(1.039896f,    0.174120f, 0.052569f),
            new Vector(0.133633f,   -0.487222f, 0.052569f),
            new Vector(-0.168288f,  -0.451040f, 0.052569f),
            new Vector(0.011073f,    0.030272f, 0.052569f),
            new Vector(-0.267362f,  -0.234490f, 0.052569f),
            new Vector(-0.482961f,  -0.211180f, 0.052569f),
            new Vector(-0.267362f,  -0.234490f, 0.052569f),
            new Vector(-0.267362f,  -0.234490f, 0.052569f),
            new Vector(-0.482961f,  -0.211180f, -0.061972f),
            new Vector(-0.236975f,   0.060935f, -0.061972f),
            new Vector(-0.457712f,   0.299137f, -0.061972f),
            new Vector(-0.148784f,   0.360626f, -0.061972f),
            new Vector(0.447550f,    0.353084f, -0.061972f),
            new Vector(0.089222f,    0.377968f, -0.061972f),
            new Vector(0.189356f,   -0.142691f, -0.061972f),
            new Vector(0.712750f,    0.297276f, -0.061972f),
            new Vector(1.039896f,    0.174120f, -0.061972f),
            new Vector(0.133633f,   -0.487222f, -0.061972f),
            new Vector(-0.168288f,  -0.451040f, -0.061972f),
            new Vector(0.011073f,    0.030272f, -0.061972f),
            new Vector(-0.267362f,  -0.234490f, -0.061972f),
            new Vector(-0.482961f,  -0.211180f, -0.061972f),
            new Vector(-0.267362f,  -0.234490f, -0.061972f),
            new Vector(-0.267362f,  -0.234490f, -0.061972f)
        };

        public void Draw(Graphics g, IReadOnlyList<Vector> _vertexes)
        {
            Pen pen = new Pen(Color, 2f);

            for (int i = 0; i < Indices.Length; i += 2)
            {
                var start = _vertexes[Indices[i] - 1];
                var end = _vertexes[Indices[i + 1] - 1];

                g.DrawLine(pen, start.x, start.y, end.x, end.y);
            }
        }

        private int[] Indices = new int[]
        {
            3 ,1,
            8 ,7,
            2 ,4,
            4 ,3,
            7 ,5,
            5 ,6,
            6 ,2,
            9 ,8,
            10, 9,
            11, 10,
            12, 11,
            13, 12,
            16, 15,
            13, 14,
            14, 1,
            1 ,15,
            16, 13,
            19, 17,
            24, 23,
            18, 20,
            20, 19,
            23, 21,
            21, 22,
            22, 18,
            25, 24,
            26, 25,
            27, 26,
            28, 27,
            29, 28,
            32, 31,
            29, 30,
            30, 17,
            17, 31,
            32, 29,
            4 ,20,
            18, 2,
            11, 27,
            28, 12,
            3 ,19,
            29, 13,
            5 ,21,
            23, 7,
            16, 32,
            31, 15,
            6 ,22,
            14, 30,
            1 ,17,
            8 ,24,
            25, 9,
            26, 10,
        };
    }
}