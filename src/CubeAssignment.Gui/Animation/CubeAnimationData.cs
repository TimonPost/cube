using CubeAssignment.Gui.Scene;

namespace CubeAssignment.Gui.Animation
{
    /// <summary>
    ///     Data object passed into the animation phases.
    /// </summary>
    public class CubeAnimationData
    {
        public CubeAnimationData(MeshSceneObject meshSceneObject, Camera camera)
        {
            MeshSceneObject = meshSceneObject;
            Camera = camera;
        }

        /// <summary>
        ///     Mesh object under animation.
        /// </summary>
        public MeshSceneObject MeshSceneObject { get; }

        /// <summary>
        ///     Camera object under animation.
        /// </summary>
        public Camera Camera { get; }
    }
}