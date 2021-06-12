﻿using System.Drawing;

namespace CubeAssignment.Gui.Scene
{
    public class MeshSceneObject : SceneObject
    {
        protected readonly Renderer Renderer;

        public MeshSceneObject(Mesh mesh, Renderer renderer)
        {
            Renderer = renderer;
            Mesh = mesh;
        }

        public override void Draw(Graphics graphics, Camera camera)
        {
            var modelMatrix = Matrix.ModelTransformation(Scale, Rotation, Position);
            Renderer.Draw(graphics, Mesh.VertexBuffer, Mesh.IndexBuffer, camera, modelMatrix);
        }

        public override void Update()
        {
        }

        public Vector Rotation = new Vector();
        public Vector Position = new Vector();
        public Vector Scale = new Vector(1, 1, 1, 1);

        public Mesh Mesh { get; }
    }
}