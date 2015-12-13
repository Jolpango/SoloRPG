using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloRPG
{
    class Particle
    {
        public Texture2D Texture { get; set; }        
        public Vector2 Position { get; set; }        
        public Vector2 Velocity { get; set; }        
        public float Angle { get; set; }            
        public float AngularVelocity { get; set; }    
        public float Size { get; set; }                
        public float alpha;
        float reduction;

        public Particle(float reduction, Texture2D texture, Vector2 position, float angle, float angularVelocity, float size, Vector2 velocity)
        {
            Texture = texture;
            Position = position;
            Velocity = velocity;
            Angle = angle;
            AngularVelocity = angularVelocity;
            Size = size;
            alpha = 1;
            this.reduction = reduction;
        }
        public void Update()
        {
            Position += Velocity;
            Angle += AngularVelocity;
            alpha -= reduction;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, Texture.Width, Texture.Height);
            Vector2 origin = new Vector2(Texture.Width / 2, Texture.Height / 2);
 
            spriteBatch.Draw(Texture, Position, sourceRectangle, Color.White * alpha, Angle, origin, Size, SpriteEffects.None, 0f);
        }
    }
}
