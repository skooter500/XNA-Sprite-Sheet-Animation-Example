using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame10
{
    public class Tonaty:AnimatedSprite
    {
        public Tonaty()
            : base()
        {
            Animations.Add("bounce1", new Animation(new Vector2(16, 2), 32, 64, 32, 0, 3));
            Animations.Add("bounce2", new Animation(new Vector2(16, 66), 32, 64, 32, 0, 3));
            Animations.Add("bounce3", new Animation(new Vector2(16, 192), 32, 64, 32, 0, 3));
            Position = new Vector2(500, 200);
            CurrentAnimation = "bounce1";
        }

        public override void LoadContent()
        {
            Sprite = Game1.Instance.Content.Load<Texture2D>("tonatytrans");
            base.LoadContent();
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float timeDelta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            float speed = 50.0f;
            Animating = false;

            if (kState.IsKeyDown(Keys.Q))
            {
                CurrentAnimation = "bounce1";            
                Animating = true;
            }

            if (kState.IsKeyDown(Keys.W))
            {
                CurrentAnimation = "bounce2";
                Animating = true;
            }

            if (kState.IsKeyDown(Keys.E))
            {
                CurrentAnimation = "bounce3";
                Animating = true;
            }

            base.Update(gameTime);
        }
    }
}
