﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace TestGame01
{
    
    public class Move
    {
        private Vector2 pos;
        private int[] resolution;

        public Move(string typeMove,int[] resolution,Vector2 position)
        {
            this.resolution = resolution;
            pos = position;
        }
        public void CloseMove(int x,int y,int elementSize)
        {
            //When press right
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                pos.X += x;
                if (pos.X > resolution[0]-elementSize) pos.X = resolution[0]-elementSize;
            }
            //When press left
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                pos.X -= x;
                if (pos.X < 0) pos.X = 0;
            }
            //When press up
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                pos.Y -= y;
                if (pos.Y < 0) pos.Y = 0;
            }
            //When press down
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                pos.Y += y;
                if (pos.Y > resolution[1]-elementSize) pos.Y = resolution[1]-elementSize;
            }
        }
        public void InfinityMove(int x,int y)
        {
            //When press right
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                pos.X += x;
                if (pos.X > resolution[0]) pos.X = 0;
            }
            //When press left
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                pos.X -= x;
                if (pos.X < 0) pos.X = resolution[0];
            }
            //When press up
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                pos.Y -= y;
                if (pos.Y < 0) pos.Y = resolution[1];
            }
            //When press down
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                pos.Y += y;
                if (pos.Y > resolution[1]) pos.Y = 0;
            }
        }
        private void Move3()
        {

        }
        public Vector2 Position
        {
            get { return pos; }
        }
    }
}
