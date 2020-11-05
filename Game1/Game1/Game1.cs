using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace DasBooseh
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private SpriteFont aFont;
        private Texture2D layer1;                    // värld
        private Texture2D layer2;
        private Texture2D layer3;
        private Texture2D currentTexture;


        private Texture2D normalTexture;             //spelare
        private Texture2D jumpingTexture;
        private Texture2D crouchingTexture;
        private Vector2 playerPosition;
        private Vector2 playerSpeed;
        bool isJumping;
        bool isCrouching;
        bool isShooting;
        private bool hit;

        //misc

        private Texture2D fireballLeftTexture;
        private Texture2D fireballTexture;
        private List<Vector2> fireballs;
        private List<Vector2> fireballsLeft;
        private int fireballTimer = 120;
        private Random rnd;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here                              // Start-data.
            playerPosition = new Vector2(300, 200);
            fireballs = new List<Vector2>();
            fireballsLeft = new List<Vector2>();
            rnd = new Random();

            base.Initialize();
        }

        protected override void LoadContent()                        // Loada efter initsiera alltid.
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            layer1 = Content.Load<Texture2D>("layer1");
            layer2 = Content.Load<Texture2D>("layer2");
            layer3 = Content.Load<Texture2D>("layer3");
            normalTexture = Content.Load<Texture2D>("normal");
            jumpingTexture = Content.Load<Texture2D>("jump");
            crouchingTexture = Content.Load<Texture2D>("crouch");
            fireballTexture = Content.Load<Texture2D>("fireball");
            fireballLeftTexture = Content.Load<Texture2D>("fireballLeft");
            aFont = Content.Load<SpriteFont>("aFont");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            // logik för Golv
            playerPosition += playerSpeed;
            if (playerPosition.Y > 200)
            {
                playerPosition = new Vector2(playerPosition.X, 200);
                playerSpeed = Vector2.Zero;
                isJumping = false;
            }
            //gravitation
            playerSpeed += new Vector2(0, 0.6f);
            //Movement
            var state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.W) && !isJumping)              // använda bool för att avgöra state
            {
                playerSpeed = new Vector2(0, -10.0f);
                isJumping = true;

            }
            if (state.IsKeyDown(Keys.S))
            {
                playerSpeed = new Vector2(0, 9.0f);
                isCrouching = true;
            }
            else
                isCrouching = false;
            if (state.IsKeyDown(Keys.D))
            {
                playerPosition += new Vector2(+5, 0);
            }

            if (state.IsKeyDown(Keys.A))
            {
                playerPosition += new Vector2(-5, 0);
            }
            // Fireballs
            fireballTimer--;
            if (fireballTimer == 0)
            {
                fireballTimer = 80;   // 60 per second.

                if (rnd.Next(1 + 1) == 0)
                {
                    fireballsLeft.Add(new Vector2(800, 200));
                    //fireballs.Add(playerPosition); // reverse shooting
                }
                else
                {
                    fireballsLeft.Add(new Vector2(800, 240));
                    //fireballs.Add(playerPosition); // reverse shooting

                }


            }
            for (int i = 0; i < fireballsLeft.Count; i++)
            {

                fireballsLeft[i] = fireballsLeft[i] + new Vector2(-4, 0);
            }

            if (fireballTimer == 0)
            {
                fireballTimer = 120;

            }
            for (int i = 0; i < fireballs.Count; i++)
            {
                fireballs[i] = fireballs[i] + new Vector2(8, 0);

            }
            //if (state.IsKeyDown(Keys.Space))
            //{
            //    isShooting = true;
            //    for (int i = 0; i < fireballs.Count; i++)
            //    {
            //        fireballs[i] = fireballs[i] + new Vector2(1, 0);
            //    }
            //}

            // Collision

            //if (isShooting)
            //{
            //    _spriteBatch.Draw(fireballTexture, playerPosition, Color.White);   TODO: Måste ändra logic och addera sprite...
            //}
            if (isJumping)
            {
                currentTexture = jumpingTexture;
            }
            else if (isCrouching)
            {
                currentTexture = crouchingTexture;
            }
            else
            {
                currentTexture = normalTexture;
            }
            //playerBox
            Rectangle playerBox = new Rectangle((int)playerPosition.X, (int)playerPosition.Y, currentTexture.Width, currentTexture.Height);

            //projectileBox
            foreach (var fireball in fireballs)
            {
                Rectangle fireballBox = new Rectangle((int)fireball.X, (int)fireball.Y, fireballTexture.Width, fireballLeftTexture.Height);

                //Överlappar vi?
                hit = false; // Vi har ingen kollision just nu.
                var kollision = Intersection(playerBox, fireballBox);

                if (kollision.Width > 0 && kollision.Height > 0)
                {
                    Rectangle r1 = Normalize(playerBox, kollision);
                    Rectangle r2 = Normalize(fireballBox, kollision);
                    hit = TestCollision(currentTexture, r1, fireballTexture, r2);     // här upptäcker vi kollision            
                }

            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            _spriteBatch.Draw(layer1, Vector2.Zero, Color.White);
            _spriteBatch.Draw(layer2, Vector2.Zero, Color.White);
            _spriteBatch.Draw(layer3, Vector2.Zero, Color.White);
            _spriteBatch.End();

            _spriteBatch.Begin();

            _spriteBatch.DrawString(aFont, ((int)gameTime.TotalGameTime.TotalSeconds).ToString(), new Vector2(10, 20), Color.White);

            if (hit)
            {
                _spriteBatch.DrawString(aFont, "HIT!!", new Vector2(10, 40), Color.White);
            }
            _spriteBatch.Draw(currentTexture, playerPosition, Color.White);


            // draw fireball contineous shooting

            foreach (var fireball in fireballs)
            {
                _spriteBatch.Draw(fireballTexture, fireball, Color.White);
            }

            // draw fireball left.

            foreach (var fireball in fireballsLeft)
            {
                _spriteBatch.Draw(fireballLeftTexture, fireball, Color.White);
            }


            _spriteBatch.End();
            // TODO: Add your drawing code here
            base.Draw(gameTime);
        }
        public static Rectangle Normalize(Rectangle reference, Rectangle overlap)
        {
            //Räkna ut en rektangel som kan användas relativt till referensrektangeln
            return new Rectangle(
                overlap.X - reference.X,
                overlap.Y - reference.Y,
                overlap.Width,
                overlap.Height);
        }

        public static bool TestCollision(Texture2D t1, Rectangle r1, Texture2D t2, Rectangle r2)  // see och lär - väldigt fin metod.
        {
            //Beräkna hur många pixlar som finns i området som ska undersökas
            int pixelCount = r1.Width * r1.Height;
            uint[] texture1Pixels = new uint[pixelCount];
            uint[] texture2Pixels = new uint[pixelCount];
            //Kopiera ut pixlarna från båda områdena
            t1.GetData(0, r1, texture1Pixels, 0, pixelCount);
            t2.GetData(0, r2, texture2Pixels, 0, pixelCount);
            //Jämför om vi har några pixlar som överlappar varandra i områdena
            for (int i = 0; i < pixelCount; ++i)
            {
                if (((texture1Pixels[i] & 0xff000000) > 0) && ((texture2Pixels[i] & 0xff000000) > 0))
                {
                    return true;
                }
            }
            return false;
        }
        public static Rectangle Intersection(Rectangle r1, Rectangle r2)
        {
            int x1 = Math.Max(r1.Left, r2.Left);
            int y1 = Math.Max(r1.Top, r2.Top);
            int x2 = Math.Min(r1.Right, r2.Right);
            int y2 = Math.Min(r1.Bottom, r2.Bottom);

            if ((x2 >= x1) && (y2 >= y1))
            {
                return new Rectangle(x1, y1, x2 - x1, y2 - y1);
            }
            return Rectangle.Empty;
        }
    }
}
