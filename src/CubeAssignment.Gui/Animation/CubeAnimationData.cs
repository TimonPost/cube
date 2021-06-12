using CubeAssignment.Gui.Scene;

namespace CubeAssignment.Gui.Animation
{
    public class CubeAnimationData
    {
        public MeshSceneObject MeshSceneObject { get; }
        public Camera Camera { get; }

        public CubeAnimationData(MeshSceneObject meshSceneObject, Camera camera)
        {
            MeshSceneObject = meshSceneObject;
            Camera = camera;
        }
    }
}