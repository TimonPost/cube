using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using MatrixTransformations.Math;
using MatrixTransformations.World;
using Matrix = MatrixTransformations.Math.Matrix;

namespace MatrixTransformations
{
    public class Renderer
    {
        private Pen _pen;
        private LinearGradientBrush _brush;


        private int ScreenWidth { get; set; }
        private int ScreenHeight { get; set; }

        public Renderer(int screenWidth, int screenHeight)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
        }

        /// <summary>
        /// Draws vertices
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="vertexes"></param>
        /// <param name="indexes"></param>
        /// <param name="modelMatrix"></param>
        public void Draw(Graphics graphics, IReadOnlyList<Vertex> vertexes, IReadOnlyList<int> indexes, Matrix modelViewMatrix)
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
                    Vertex firstVertex = vertexes[indexEnumerator.Current];
                    Vector firstVector = Transform(firstVertex.Vector);

                    indexEnumerator.MoveNext();
                    Vertex secondVertex = vertexes[indexEnumerator.Current];
                    Vector secondVector = Transform(secondVertex.Vector);

                    var point1 = new PointF(firstVector.x, firstVector.y);
                    var point2 = new PointF(secondVector.x, secondVector.y);

                    using (var linearGradientBrush = new LinearGradientBrush(point1, point2, firstVertex.Color, secondVertex.Color))
                    {
                        if (_pen == null)
                        {
                            _pen = new Pen(linearGradientBrush, 3f);
                        }
                        else
                        {
                            _pen.Brush = linearGradientBrush;
                        }
                        graphics.DrawLine(_pen, point1, point2);
                    }
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