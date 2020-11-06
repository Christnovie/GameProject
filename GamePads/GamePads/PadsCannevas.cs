using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Threading;

namespace GamePads
{
    public class PadsCannevas 
    {
        private readonly int[] smSize = {500,300};
        private readonly int[] mdSize = {1000,550};
        private readonly int[] bgSize = {1500,800};
        private List<PadsCase> padsCases;
        private PadsGraphique game;
        private Rectangle[] rectangles;
        private int[] canvasSize;
        private PadsCount Pads = PadsCount.Big;
        public PadsCannevas(List<PadsCase> padsCases,object game)
        {
            this.padsCases = padsCases;
            this.game = (PadsGraphique)game;
          
        }        
        public void Draw()
        {
            padsCases[0].Position = new Vector2(CanvasSize[0] - padsCases[0].Size.Width, CanvasSize[1]-padsCases[0].Size.Height);
            game.Sprite.Draw(padsCases[0].padcase, padsCases[0].Size, Color.Red);
        }
        public int[] CanvasSize
        {
            get
            {
                if (game.WindowsSize[0] < 2000 || game.WindowsSize[1] < 1200)
                {
                    Pads = PadsCount.Medium;
                }
                else { Pads = PadsCount.Medium; }
                switch (Pads)
                {
                    case PadsCount.Big:
                        canvasSize = this.bgSize;
                        return canvasSize;
                    case PadsCount.Medium:
                        canvasSize = this.mdSize;
                        return canvasSize;
                    case PadsCount.Small:
                        {
                            canvasSize = this.smSize;
                            return canvasSize;
                        }
                    default: return canvasSize;
                }
            }          
    
        }
        public Vector2 Position
        {
            get { throw new NotImplementedException(); }
        }
    }
}
