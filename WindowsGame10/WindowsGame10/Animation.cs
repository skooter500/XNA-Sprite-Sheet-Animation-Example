using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WindowsGame10
{
    public class Animation
    {       
        int startFrame;
        int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        Vector2 origin;
        public Vector2 Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public int StartFrame
        {
            get { return startFrame; }
            set { startFrame = value; }
        }
        int endFrame;

        public int EndFrame
        {
            get { return endFrame; }
            set { endFrame = value; }
        }

        int spacingX;

        public int SpacingX
        {
            get { return spacingX; }
            set { spacingX = value; }
        }

        public Animation(Vector2 origin, int width, int height, int spacingX, int startFrame, int endFrame)
        {
            this.origin = origin;
            this.width = width;
            this.height = height;
            this.spacingX = spacingX;
            this.startFrame = startFrame;
            this.endFrame = endFrame;
        }

        public Animation(Vector2 origin, int width, int height, int startFrame, int endFrame):this(origin, width, height, 0, startFrame, endFrame)
        {
            
        }
    }
}
