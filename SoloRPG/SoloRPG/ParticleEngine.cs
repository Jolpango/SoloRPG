using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloRPG
{
    class ParticleEngine
    {
        private Random random;
        public Vector2 EmitterLocation { get; set; }
        private List<Particle> particles;
        private Texture2D texture;
        public int total;

        public ParticleEngine(Texture2D texture)
        {
            this.texture = texture;
            this.particles = new List<Particle>();
            random = new Random();
        }

        public void AddParticles(int count, Vector2 pos)
        {
            for (int i = 0; i < count; i++)
            {
                total++;
                EmitterLocation = pos;
                particles.Add(GenerateNewParticle());
            }
        }

        public void UpdateParticles()
        {
            for (int particle = 0; particle < particles.Count; particle++)
            {
                particles[particle].Update();
                if (particles[particle].alpha <= 0)
                {
                    particles.RemoveAt(particle);
                    particle--;
                    total--;
                }
            }
        }

        private Particle GenerateNewParticle()
        {
            Texture2D texture = this.texture;
            Vector2 position = EmitterLocation;
            Vector2 velocity = new Vector2(1f * (float)(random.NextDouble() * 2 - 1), 1f * (float)(random.NextDouble() * 2 - 1));
            float angle = 0;
            float angularVelocity = 0.1f * (float)(random.NextDouble() * 2 - 1);
            float size = (float)random.NextDouble();
            float reduction = 1.5f / (float)random.Next(10, 40);

            return new Particle(reduction, texture, position, angle, angularVelocity, size, velocity);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int index = 0; index < particles.Count; index++)
            {
                particles[index].Draw(spriteBatch);
            }
        }
    }
}
