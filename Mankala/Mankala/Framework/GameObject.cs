using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

//Class used for drawable game objects, so that we don't have to specify drawing logic in all classes.
public class GameObject
{
    protected string textureName;

    protected Texture2D texture;

    protected Vector2 position;

    public GameObject()
    {
    }

    public virtual void Initialize()
    {
        texture = TextureHandler.LoadTexture(textureName);
    }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        if (texture == null)
            texture = TextureHandler.LoadTexture(textureName);

        spriteBatch.Draw(texture, position, Color.White);
    }

    public virtual void Update()
    {
        checkClick();
    }

    protected virtual void onClick()
    {
        System.Diagnostics.Debug.WriteLine("clicked " + textureName);
    }

    protected void checkClick()
    {

        //First, we determine if there has been a mouseclick in the last game cycle. This is done first so the rest of the code isn't executed if there hasn't been a click.
        if (!InputModule.MouseLeftButtonPressed())
        {
            return;
        }

        //Then, set up the rectangle that the object spans. We are not using round objects, so a rectangle works.
        Rectangle rect = new Rectangle();
        rect.X = (int)position.X;
        rect.Y = (int)position.Y;
        rect.Width = texture.Width;
        rect.Height = texture.Height;

        //Check if the click was in this object's rectangle
        if (rect.Contains(InputModule.MousePosition))
        {
            this.onClick();
        }
    }

    public void setPosition(int x, int y)
    {
        position = new Vector2(x, y);
    }



}

