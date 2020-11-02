using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Hole: GameObject
{
    Player owner;
    List<Stone> stones;

    public Hole(int amountOfStones, Player o)
    {
        stones = new List<Stone>();
        owner = o;
        for (int i = 0; i < amountOfStones; i++)
        {
            stones.Add(new Stone());
        }
    }

    public override void Initialize()
    {
        textureName = "hole";
        base.Initialize();
    }

    
    public int GetStoneAmount(int stones)
    {
        return stones;
    }

    public void addStone()
    {
        stones.Add(new Stone());
    }

    public void removeStone()
    {
        stones.RemoveAt(0);
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        if (owner.getPlayerNumber() == 1)
        {
            spriteBatch.Draw(texture, position, Color.White);
        } 
        else
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }


}
