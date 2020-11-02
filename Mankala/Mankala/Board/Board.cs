using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Board : GameObject
{
    List<Hole> holes;
    List<Stone> stones = new List<Stone>();

    //constructor Board
    public Board() : base()
    {
        holes = new List<Hole>();
    }

    public void addHole(Hole h)
    {
        holes.Add(h);
    }

    public override void Initialize()
    {
        textureName = "placeholder";
        base.Initialize();

        foreach (Hole hole in holes)
        {
            hole.Initialize();
        }
    }

    public override void Update()
    {
        base.Update();

        foreach (Hole hole in holes)
        {
            hole.Update();
        }
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        base.Draw(spriteBatch);

        foreach (Hole hole in holes)
        {
            hole.Draw(spriteBatch);
        }
    }
}

