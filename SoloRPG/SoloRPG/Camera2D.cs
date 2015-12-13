using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloRPG
{
    public class Camera2D
    {
        public float zoom;
        public Matrix transform;
        public Vector2 position;

        public Camera2D()
        {
            zoom = 1f;
            position = new Vector2(0, 0);
        }
        public void SetCameraPostion(Vector2 newPosition)
        {
            position = newPosition;
        }
        public Matrix GetTransformation(GraphicsDevice graphicsDevice)
        {
            transform = Matrix.CreateTranslation(new Vector3(-position.X, -position.Y, 0)) *

                                         Matrix.CreateScale(new Vector3(zoom, zoom, 1)) *
                                         Matrix.CreateTranslation(new Vector3(800 * 0.5f, 400 * 0.5f, 0));

            return transform;
        }
    }
}
