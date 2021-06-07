using System;
using System.Collections.Generic;
using System.Drawing;
using MatrixTransformations.MathCustom;

namespace MatrixTransformations.World
{
    public class Mesh
    {
        public Mesh(IReadOnlyList<Vertex> vertexBuffer, IReadOnlyList<int> indexBuffer)
        {
            VertexBuffer = vertexBuffer;
            IndexBuffer = indexBuffer;
        }

        public IReadOnlyList<Vertex> VertexBuffer { get; }
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

            IReadOnlyList<Vertex> vertexbuffer = new List<Vertex>
            {
               new Vertex(new Vector( 1.0f,  1.0f, 1.0f), Color.Blue),     //0
               new Vertex( new Vector( 1.0f, -1.0f, 1.0f),Color.Green),     //1
               new Vertex( new Vector(-1.0f, -1.0f, 1.0f),Color.Red),     //2
               new Vertex( new Vector(-1.0f,  1.0f, 1.0f),Color.Blue),     //3
              
               new Vertex( new Vector( 1.0f,  1.0f, -1.0f),Color.Blue),    //4
               new Vertex( new Vector( 1.0f, -1.0f, -1.0f),Color.Green),    //5
               new Vertex( new Vector(-1.0f, -1.0f, -1.0f),Color.Red),    //6
               new Vertex( new Vector(-1.0f,  1.0f, -1.0f),Color.Blue),    //7
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

        public static Mesh CreateLine(Vector position1, Color color1, Vector position2, Color color2)
        {
            IReadOnlyList<Vertex> vertexbuffer = new List<Vertex>
            {
                new Vertex(position1, color1),
                new Vertex(position2, color2),
            };

            IReadOnlyList<int> indexBuffer = new List<int>()
            {
                0,1
            };
            return new Mesh(vertexbuffer, indexBuffer);
        }
    }
}