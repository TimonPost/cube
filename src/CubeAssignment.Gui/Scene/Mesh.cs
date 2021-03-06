using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using OBJ3DWavefrontLoader;

namespace CubeAssignment.Gui.Scene
{
    /// <summary>
    ///     Represents a 3D Model
    /// </summary>
    public class Mesh
    {
        public Mesh(IReadOnlyList<Vertex> vertexBuffer, IReadOnlyList<int> indexBuffer)
        {
            VertexBuffer = vertexBuffer;
            IndexBuffer = indexBuffer;
        }

        /// <summary>
        ///     Vertex buffer containing information about each vertex for this mesh.
        /// </summary>
        public IReadOnlyList<Vertex> VertexBuffer { get; }

        /// <summary>
        ///     Index buffer into the vertexbuffer.
        /// </summary>
        public IReadOnlyList<int> IndexBuffer { get; }

        /// <summary>
        ///     Creates a line mesh.
        /// </summary>
        /// <param name="position1"></param>
        /// <param name="color1"></param>
        /// <param name="position2"></param>
        /// <param name="color2"></param>
        /// <returns></returns>
        public static Mesh CreateLine(Vector position1, Color color1, Vector position2, Color color2)
        {
            IReadOnlyList<Vertex> vertexbuffer = new List<Vertex>
            {
                new Vertex(position1, color1),
                new Vertex(position2, color2)
            };

            IReadOnlyList<int> indexBuffer = new List<int>
            {
                0, 1
            };
            return new Mesh(vertexbuffer, indexBuffer);
        }

        #region Cube

        public static Mesh FromObj(string path, Color vertexColor)
        {
            var vertexes = new List<Vertex>();
            var indexes = new List<int>();

            SimpleMesh objMesh;
            using (var reader = new StreamReader(path))
            {
                objMesh = SimpleMesh.LoadFromObj(reader);
                vertexes.AddRange(objMesh.vertices.Select(v => new Vertex(new Vector(v.X, v.Y, v.Z), vertexColor)));

                var edges = new HashSet<long>();

                foreach (var face in objMesh.facesVertsIndxs)
                    for (var i = 0; i < face.Count; i++)
                    {
                        var first = face[i] - 1; // Obj index starts at 1...
                        var second = face[(i + 1) % face.Count] - 1;

                        // We only want to render each edge once,
                        // so we hash the indexes and check if the are already added.
                        long hash;
                        if (first < second)
                            hash = ((long) first << 32) | second;
                        else
                            hash = ((long) second << 32) | first;

                        if (edges.Add(hash))
                        {
                            indexes.Add(first);
                            indexes.Add(second);
                        }
                    }

                return new Mesh(vertexes, indexes);
            }
        }

        /// <summary>
        ///     Singleton cube mesh
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
                new Vertex(new Vector(1.0f, 1.0f, 1.0f), Color.Red), //0
                new Vertex(new Vector(1.0f, -1.0f, 1.0f), Color.Lime), //1
                new Vertex(new Vector(-1.0f, -1.0f, 1.0f), Color.Lime), //2
                new Vertex(new Vector(-1.0f, 1.0f, 1.0f), Color.Red), //3

                new Vertex(new Vector(1.0f, 1.0f, -1.0f), Color.Lime), //4
                new Vertex(new Vector(1.0f, -1.0f, -1.0f), Color.Blue), //5
                new Vertex(new Vector(-1.0f, -1.0f, -1.0f), Color.Red), //6
                new Vertex(new Vector(-1.0f, 1.0f, -1.0f), Color.Blue) //7
            };

            IReadOnlyList<int> indexBuffer = new List<int>
            {
                1, 2, // Front
                2, 3,
                3, 0,
                0, 1,

                5, 6, // Back
                6, 7,
                7, 4,
                4, 5,

                5, 1, // Lines between front and back
                6, 2,
                7, 3,
                4, 0
            };

            return new Mesh(vertexbuffer, indexBuffer);
        });

        public static Mesh Cube => LazyCube.Value;

        #endregion
    }
}