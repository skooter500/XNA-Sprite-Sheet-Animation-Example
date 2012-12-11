using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace WindowsGame10
{
    public class Person:AnimatedSprite
    {
        public Person()
            : base()
        {
            Animations.Add("walkdown", new Animation(Vector2.Zero, 32, 48, 0, 3));
            Animations.Add("walkleft", new Animation(Vector2.Zero, 32, 48, 4, 7));
            Animations.Add("walkright", new Animation(Vector2.Zero, 32, 48, 8, 11));
            Animations.Add("walkup", new Animation(Vector2.Zero, 32, 48, 12, 15));
            CurrentAnimation = "walkup";
            Position = new Vector2(300, 300);
        }

        public override void LoadContent()
        {
            Sprite = Game1.Instance.Content.Load<Texture2D>("sprite_sheet");
            
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float timeDelta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            float speed = 50.0f;
            Animating = false;
            if (kState.IsKeyDown(Keys.A))
            {
                CurrentAnimation = "walkleft";
                Look = Vector2.UnitX;
                Position -= Look * speed * timeDelta;
                Animating = true;
            }

            if (kState.IsKeyDown(Keys.D))
            {
                CurrentAnimation = "walkright";
                Look = Vector2.UnitX;
                Position += Look * speed * timeDelta;
                Animating = true;
            }

            if (kState.IsKeyDown(Keys.W))
            {
                CurrentAnimation = "walkup";
                Look = Vector2.UnitY;
                Position -= Look * speed * timeDelta;
                Animating = true;
            }

            if (kState.IsKeyDown(Keys.S))
            {
                CurrentAnimation = "walkdown";
                Look = Vector2.UnitY;
                Position += Look * speed * timeDelta;
                Animating = true;
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
