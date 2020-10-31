using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GamePads
{
    public class Collider2D
    {
        public static bool Is_Clicked_Mouse(Vector2 vector,Rectangle padcase)
        {
            bool state = false;
            for (int ver = (int)vector.Y; ver < padcase.Height + (int)vector.Y; ver++)
            {
                for (int hor = (int)vector.X; hor < padcase.Width + (int)vector.X; hor++)
                {
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed && new Vector2(Mouse.GetState().X, Mouse.GetState().Y) == new Vector2(hor, ver))
                    {                       
                        state = true;
                        return state;                        
                    }
                }
            }
            return state;
        }
        public static bool Is_Clicked_Mouse_Rec(Vector2 vector, Texture2D padcase)
        {
            bool state = false;
            for (int ver = (int)vector.Y; ver < padcase.Height + (int)vector.Y; ver++)
            {
                for (int hor = (int)vector.X; hor < padcase.Width + (int)vector.X; hor++)
                {
                    if (Mouse.GetState().LeftButton == ButtonState.Pressed && new Vector2(Mouse.GetState().X, Mouse.GetState().Y) == new Vector2(hor, ver))
                    {
                        state = true;
                        return state;
                    }
                }
            }
            return state;
        }
        public static bool OnCollision()
        {
            throw new NotImplementedException();
        }
        public static bool Poligone_Collision()
        {
            throw new NotImplementedException();
        }

    }
}
