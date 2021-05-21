using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MatrixTransformations.Math;
using MatrixTransformations.World;

namespace MatrixTransformations
{
    public class Renderer
    {
        private Pen _linePen;

        private int ScreenWidth { get; set; }
        private int ScreenHeight { get; set; }

        public Renderer(int screenWidth, int screenHeight)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            _linePen = new Pen(Color.Black);
        }

        /// <summary>
        /// Draws vertices
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="vertexes"></param>
        /// <param name="indexes"></param>
        /// <param name="modelMatrix"></param>
        public void Draw(Graphics graphics, IReadOnlyList<Vector> vertexes, IReadOnlyList<int> indexes, Matrix modelViewMatrix)
        {
            Vector Transform(Vector inputVector)
            {
                Vector vector = inputVector;
                vector.w = 1;

                var transformed = Vector.Transform(vector, modelViewMatrix);
                var projection = ProjectionTransformation(2, transformed.z);
                Vector projected = Vector.Transform(transformed, projection);

                //Scale to screen
                projected.x = (projected.x + 1f) * ScreenWidth * 0.5f;
                projected.y = (1f - projected.y) * ScreenHeight * 0.5f;
                return projected;
            }

            using (var indexEnumerator = indexes.GetEnumerator())
            {
                while (indexEnumerator.MoveNext())
                {
                    Vector first = Transform(vertexes[indexEnumerator.Current]);
                    
                    indexEnumerator.MoveNext();
                    Vector second = Transform(vertexes[indexEnumerator.Current]);
                    graphics.DrawLine(_linePen, first.x, first.y, second.x, second.y);
                }
            }
        }

        public static Matrix ProjectionTransformation(float distance, float z)
        {
            float projectedZ = 1 / (distance - z);
            var projectionMatrix = new Matrix(
                projectedZ, 0, 0, 0,
                0, projectedZ, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            return projectionMatrix;
        }
    }
}