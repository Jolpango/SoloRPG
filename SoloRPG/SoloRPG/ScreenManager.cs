using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoloRPG
{
    public class ScreenManager
    {
        public Camera2D camera;
        private static ScreenManager instance;
        GameScreen currentScreen, newScreen;
        bool switching = false;
        public Image pixel;
        static XmlManager<ScreenManager> x = new XmlManager<ScreenManager>();
        private ContentManager content;
        public ContentManager Content
        {
            get
            {
                return content;
            }
        }

        Player test = new Player();

        private ScreenManager() 
        {
        }

        public static ScreenManager Instance 
        {
            get 
            {
                if (instance == null) 
                {
                    instance = x.Load("Load/ScreenManager.xml");
                }
                return instance;
            }
        }

        public void LoadContent(ContentManager content) 
        {
            camera = new Camera2D();
            camera.position = new Vector2(400, 300);
            this.content = content;
            currentScreen = new GameScreen();
            ChangeScreen("GameScreen");
            currentScreen.LoadContent();
            pixel.LoadContent();
            pixel.Alpha = 1;
            pixel.Scale = new Vector2(800, 600);
            test.LoadContent();
        }

        public void UnloadContent() 
        {
            currentScreen.UnloadContent();
        }

        public void Update(GameTime gameTime) 
        {
            if (switching)
            {
                if (pixel.Alpha < 1 && currentScreen != newScreen)
                    pixel.Alpha += .05f;
                else if (currentScreen != newScreen)
                    currentScreen = newScreen;
                else
                {
                    if (pixel.Alpha > 0)
                        pixel.Alpha -= .05f;
                    else
                        switching = false;

                }
            }
            else
            {
                currentScreen.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch) 
        {
            currentScreen.Draw(spriteBatch);
            pixel.Draw(spriteBatch);
        }

        public void ChangeScreen(string name)
        {
            newScreen = (GameScreen)Activator.CreateInstance(Type.GetType("SoloRPG." + name));
            newScreen.LoadContent();
            switching = true;
        }
    }
}
