using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame10
{
    public abstract class GameEntity
    {
        public Vector2 Position;
        public Vector2 Look;
        private Texture2D sprite;

        public Texture2D Sprite
        {
            get { return sprite; }
            set { sprite = value; }
        }

        public abstract void LoadContent();
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime);
    }
}
