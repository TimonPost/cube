using System.Drawing;
using MatrixTransformations.Math;

namespace MatrixTransformations.World
{
    public class MeshSceneObject : SceneObject
    {
        public MeshSceneObject(Mesh mesh)
        {
            Mesh = mesh;
        }

        public override void Draw(Graphics graphics, Matrix modelViewProjection)
        {

        }

        public override void Update()
        {
            
        }

        public Vector Rotation { get; set; }
        public Vector Position { get; set; }
        public Vector Scale { get; set; }
        
        public Mesh Mesh { get; }
    }
}