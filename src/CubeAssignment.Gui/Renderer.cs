using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using CubeAssignment.Gui.Scene;
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
        private readonly Font _font = new Font("Arial", 15);

        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }

        public Renderer(int screenWidth, int screenHeight)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
        }

        /// <summary>
        /// Get an orthographic projection matrix for the given camera. 
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static Matrix ProjectionTransformation(float d, float z)
        {
            var projectionMatrix = new Matrix(
                -d / z, 0, 0, 0,
                0, -d / z, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
            return projectionMatrix;
        }

        /// <summary>
        /// Transforms a vector with camera view matrix, model matrix.
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="inputVector"></param>
        /// <param name="modelMatrix"></param>
        /// <returns></returns>
        private Vector Transform(Camera camera, Vector inputVector, Matrix modelMatrix)
        {
            var worldspace = camera.GetMatrix() * modelMatrix;

            var viewSpace = inputVector * worldspace;
          
            var projection = ProjectionTransformation(camera.Distance, viewSpace.z);

            var newVector = viewSpace * projection;

            //Scale to screen
            newVector.x =  ScreenWidth / 2f + newVector.x;
            newVector.y = ScreenHeight / 2f - newVector.y;
            return newVector;
        }

        /// <summary>
        /// Draws text on graphics
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="text"></param>
        /// <param name="color"></param>
        /// <param name="position"></param>
        /// <param name="modelViewMatrix"></param>
        public void DrawText(Graphics graphics, string text, Color color, Vector position, Camera camera, Matrix modeViewMatrix = null)
        {
            if (_fontBrush == null)
            {
                _fontBrush = new SolidBrush(color);
            }
            else
            {
                _fontBrush.Color = color;
            }

            if (modeViewMatrix is null)
                modeViewMatrix = Matrix.Identity();
            
            position = Transform(camera, position, modeViewMatrix);
            graphics.DrawString(text, _font, _fontBrush, new PointF(position.x, position.y));
        }

        /// <summary>
        /// Draws vertices
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="vertexes"></param>
        /// <param name="indexes"></param>
        /// <param name="modelViewMatrix"></param>
        public void Draw(Graphics graphics, IReadOnlyList<Vertex> vertexes, IReadOnlyList<int> indexes, Camera camera, Matrix modelMatrix)
        {
            using (IEnumerator<int> indexEnumerator = indexes.GetEnumerator())
            {
                while (indexEnumerator.MoveNext())
                {
                    Vertex firstVertex = vertexes[indexEnumerator.Current];
                    Vector firstVector = Transform(camera, firstVertex.Position, modelMatrix);

                    indexEnumerator.MoveNext();
                    Vertex secondVertex = vertexes[indexEnumerator.Current];
                    Vector secondVector = Transform(camera, secondVertex.Position, modelMatrix);

                    var point1 = new PointF(firstVector.x, firstVector.y);
                    var point2 = new PointF(secondVector.x, secondVector.y);
                    
                    // Avoid drawing zero line, because that results in an out of memory exception.
                    if (Math.Abs(point1.X - point2.X) < 1f && Math.Abs(point1.Y - point2.Y) < 1f)
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