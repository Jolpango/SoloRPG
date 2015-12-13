using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloRPG
{
    public class Image
    {
        public Texture2D Texture;
        public Vector2 Position, Scale;
        public string Path;
        public Rectangle SourceRect;
        public float Alpha;
        ContentManager content;
        Vector2 origin;
        public bool IsActive;
        public float Rotation;
        public Color color;

        public Image()
        {
            Position = Vector2.Zero;
            Alpha = 1.0f;
            Scale = Vector2.One;
            SourceRect = Rectangle.Empty;
            Rotation = 0.0f;
            color = Color.White;
        }

        public Rectangle PositionRec 
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, SourceRect.Width, SourceRect.Height);
            }
        }

        public void LoadContent()
        {
            content = ScreenManager.Instance.Content;

            if (Path != String.Empty)
            {
                Texture = content.Load<Texture2D>(Path);
            }
            if (Texture != null)
            {
                SourceRect = new Rectangle(0, 0, Texture.Width, Texture.Height);
            }
        }

        public void UnloadContent()
        {
            content.Unload();
        }

        public void Draw(SpriteBatch spritebatch)
        {
            origin = new Vector2(SourceRect.Width / 2, SourceRect.Height / 2);
            spritebatch.Draw(Texture, Position + origin, SourceRect, color * Alpha, Rotation, origin, Scale, SpriteEffects.None, 0.0f);
        }
    }
}
