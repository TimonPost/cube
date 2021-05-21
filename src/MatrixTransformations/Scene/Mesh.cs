using System;
using System.Collections.Generic;
using MatrixTransformations.Math;

namespace MatrixTransformations.World
{
    public class Mesh
    {
        public Mesh(IReadOnlyList<Vector> vertexBuffer, IReadOnlyList<int> indexBuffer)
        {
            VertexBuffer = vertexBuffer;
            IndexBuffer = indexBuffer;
        }

        public IReadOnlyList<Vector> VertexBuffer { get; }
        public IReadOnlyList<int> IndexBuffer { get; }

        #region Cube

        /// <summary>
        /// Singleton cube mesh
        /// </summary>
        private static readonly Lazy<Mesh> LazyCube = new Lazy<Mesh>(() =>
        {
            //          7----------4
            //         /|         /|
            //        / |        / |                y
            //       /  6-------/--5                |
            //      3----------0  /                 ----x
            //      | /        | /                 /
            //      |/         |/                  z
            //      2----------1

            IReadOnlyList<Vector> vertexbuffer = new List<Vector>
            {
                new Vector( 1.0f,  1.0f, 1.0f),     //0
                new Vector( 1.0f, -1.0f, 1.0f),     //1
                new Vector(-1.0f, -1.0f, 1.0f),     //2
                new Vector(-1.0f,  1.0f, 1.0f),     //3

                new Vector( 1.0f,  1.0f, -1.0f),    //4
                new Vector( 1.0f, -1.0f, -1.0f),    //5
                new Vector(-1.0f, -1.0f, -1.0f),    //6
                new Vector(-1.0f,  1.0f, -1.0f),    //7
            };

            IReadOnlyList<int> indexBuffer = new List<int>()
            {
                1,2, // Front
                2,3,
                3,0,
                0,1,

                5,6, // Back
                6,7,
                7,4,
                4,5,

                5,1, // Lines between front and back
                6,2,
                7,3,
                4,0
            };

            return new Mesh(vertexbuffer, indexBuffer);
        });

        public static Mesh Cube => LazyCube.Value;

        #endregion
    }
}