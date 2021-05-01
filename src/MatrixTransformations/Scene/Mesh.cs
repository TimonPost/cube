using System;
using System.Collections.Generic;
using MatrixTransformations.Math;

namespace MatrixTransformations.World
{
    public class Mesh
    {
        public Mesh(Vector[] vertexBuffer, int[] indexBuffer)
        {
            VertexBuffer = vertexBuffer;
            IndexBuffer = indexBuffer;
        }

        public IReadOnlyCollection<Vector> VertexBuffer { get; }
        public IReadOnlyCollection<int> IndexBuffer { get; }

        #region Cube

        /// <summary>
        /// Singleton cube mesh
        /// </summary>
        private readonly Lazy<Mesh> _lazyCube = new Lazy<Mesh>(() =>
        {
            IReadOnlyList<MatrixTransformations.Math.Vector> vertexbuffer = new List<Vector>
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

            IReadOnlyCollection<int> indexBuffer = new List<int>()
            {

            };

            Mesh mesh = new Mesh(null, null);
            return mesh;
        });

        public Mesh Cube => _lazyCube.Value;

        #endregion
    }
}