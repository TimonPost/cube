using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Matrix = CubeAssignment.Gui.Matrix;

namespace CubeAssignment.Gui
{
    /// <summary>
    /// Used for rendering scene elements to the screen.
    /// </summary>
    public class Renderer
    {
        private Pen _pen;
        private SolidBrush _fontBrush;
        private readonly Font _font = new Font("Arial", 10);

        private int ScreenWidth { get; set; }
        private int ScreenHeight { get; set; }

        public Renderer(int screenWidth, int screenHeight)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
        }

        public static Matrix ProjectionTransformation(float distance, float z)
        {
            var projectedZ = 1 / (distance - z);
            var projectionMatrix = new Matrix(
                projectedZ, 0, 0, 0,
                0, projectedZ, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            return projectionMatrix;
        }

        private Vector Transform(Vector inputVector, Matrix modelViewMatrix)
        {
            Vector vector = inputVector;
            vector.w = 1;

            Vector transformed = Vector.Transform(vector, modelViewMatrix);
            Matrix projection = ProjectionTransformation(5, transformed.z);
            Vector projected = Vector.Transform(transformed, projection);

            //Scale to screen
            projected.x = (projected.x + 1f) * ScreenWidth * 0.5f;
            projected.y = (1f - projected.y) * ScreenHeight * 0.5f;
            return projected;
        }

        /// <summary>
        /// Draws text on graphics
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="text"></param>
        /// <param name="color"></param>
        /// <param name="position"></param>
        /// <param name="modelViewMatrix"></param>
        public void DrawText(Graphics graphics, string text, Color color, Vector position, Matrix modelViewMatrix)
        {
            if (_fontBrush == null)
            {
                _fontBrush = new SolidBrush(color);
            }
            else
            {
                _fontBrush.Color = color;
            }

            position = Transform(position, modelViewMatrix);
            graphics.DrawString(text, _font, _fontBrush, new PointF(position.x, position.y));
        }

        /// <summary>
        /// Draws vertices
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="vertexes"></param>
        /// <param name="indexes"></param>
        /// <param name="modelViewMatrix"></param>
        public void Draw(Graphics graphics, IReadOnlyList<Vertex> vertexes, IReadOnlyList<int> indexes,
            Matrix modelViewMatrix)
        {
            using (IEnumerator<int> indexEnumerator = indexes.GetEnumerator())
            {
                while (indexEnumerator.MoveNext())
                {
                    Vertex firstVertex = vertexes[indexEnumerator.Current];
                    Vector firstVector = Transform(firstVertex.Position, modelViewMatrix);

                    indexEnumerator.MoveNext();
                    Vertex secondVertex = vertexes[indexEnumerator.Current];
                    Vector secondVector = Transform(secondVertex.Position, modelViewMatrix);

                    var point1 = new PointF(firstVector.x, firstVector.y);
                    var point2 = new PointF(secondVector.x, secondVector.y);
                    
                    // Avoid drawing zero line, because that results in an out of memory exception.
                    if (Math.Abs(point1.X - point2.X) < 10f && Math.Abs(point1.Y - point2.Y) < 10f)
                    {
                        continue;
                    }

                    try
                    {
                        using var linearGradientBrush =
                            new LinearGradientBrush(point1, point2, firstVertex.Color, secondVertex.Color);
                        if (_pen == null)
                        {
                            _pen = new Pen(linearGradientBrush, 1f);
                        }
                        else
                        {
                            _pen.Brush = linearGradientBrush;
                        }

                        graphics.DrawLine(_pen, point1, point2);
                    }
                    catch
                    {
                        // It rarely happens that a 0 length line is drawn.
                        // This throws an exception that can be ignored.
                    }
                }
            }
        }
    }
}