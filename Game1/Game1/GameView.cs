using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game1
{
    class GameView
    {
        SpriteBatch spriteBatch;
        Texture2D lolTexture;
        GameModel model;
        ContentManager content;
        GraphicsDevice device;
        public GameView(GameModel model, ContentManager content, GraphicsDevice device)
        {
            this.model = model;
            this.content = content;
            this.device = device;
            lolTexture = content.Load<Texture2D>("haaaaaaas.png");
            spriteBatch = new SpriteBatch(device);
        }
        public void DrawGame()
        {
            spriteBatch.Begin();
            float scale = this.device.Viewport.Height;
            Vector2 lolViewPosition = model.lolCenterModelPosition * scale;

            //Vector2 windowCenterPosition = new Vector2(GraphicsDevice.Viewport.Width/2, GraphicsDevice.Viewport.Height/2);
            Vector2 textureDisplacement = new Vector2(lolTexture.Bounds.Width / 2, lolTexture.Bounds.Height / 2);

            Vector2 lolposition = lolViewPosition - textureDisplacement;

            spriteBatch.Draw(lolTexture, lolposition, Color.White);

            spriteBatch.End();
        }
    }
}
