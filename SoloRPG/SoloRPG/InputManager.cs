using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SoloRPG
{
    public static class InputManager
    {
        static KeyboardState currentKeyState, previousKeyState;

        public static void Update()
        {
            previousKeyState = currentKeyState;
            currentKeyState = Keyboard.GetState();
        }
        public static bool KeyPressed(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                if (currentKeyState.IsKeyDown(key) && previousKeyState.IsKeyUp(key))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool KeyDown(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                if (currentKeyState.IsKeyDown(key))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool KeyReleased(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                if (currentKeyState.IsKeyUp(key) && previousKeyState.IsKeyDown(key))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool KeyNotDown(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                if (currentKeyState.IsKeyUp(key))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
